using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

    CharacterController myController;
    public float speed = 5f;

	// Use this for initialization
	void Start () {
        myController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * speed * vertical * Time.deltaTime;
        myController.Move(movement + Physics.gravity * Time.deltaTime);

        transform.Rotate(0f, horizontal * 90f * Time.deltaTime, 0f);
	}
}
