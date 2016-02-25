using UnityEngine;
using System.Collections;

public class mouseLook : MonoBehaviour {

    float rotationY;

	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X"); //left = -1
        float mouseY = Input.GetAxis("Mouse Y"); //down = -1

        //get horizontal turning
        //camera inverted (use - mousey), camera rotates around, camera not clamped (use mathf.clamp

        transform.Rotate(0f, mouseX * Time.deltaTime * 90f, 0f);


        rotationY += -mouseY * Time.deltaTime * 90f;
        rotationY = Mathf.Clamp(rotationY, -80f, 80f);
        transform.localEulerAngles = new Vector3(rotationY, transform.localEulerAngles.y, 0f); //setting z to 0 unrolls the camera


        if (Input.GetMouseButton(0))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked; //hide the mouse, and lock the cursor to the center
        }

        if (Input.GetKeyDown(KeyCode.Escape)) //to make the cursor reappear
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
	}
}
