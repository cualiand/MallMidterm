using UnityEngine;
using System.Collections;

public class basicPlayer : MonoBehaviour
{

    CharacterController myController;
    public float speed = 5f;
    public int healthPoints = 100;

    // Use this for initialization
    void Start()
    {
        myController = GetComponent<CharacterController>();
        if (titleScreen.useNightmareMode == true )
        {
            healthPoints = 1; //nightmare mode activate
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * speed * vertical * Time.deltaTime;
        myController.Move(movement + Physics.gravity * Time.deltaTime);

        transform.Rotate(0f, horizontal * 90f * Time.deltaTime, 0f);

        if (healthPoints <= 0 ) //if health points reach 0 or below
        {
            Destroy(gameObject); // destroy the player
        }


    }
}