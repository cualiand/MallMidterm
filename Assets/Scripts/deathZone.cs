using UnityEngine;
using System.Collections;

public class deathZone : MonoBehaviour {

    void OnTriggerEnter (Collider activator) { //activator is the thing that enters the cube. note this is start
        //Destroy(activator.gameObject); //without .gameobject, you will only destroy the collider
    }

    void OnTriggerStay (Collider activator)   { //and this is update
        activator.GetComponent<basicPlayer>().healthPoints -= 1; //THIS IS HOW TO CALL SCRIPTS
    }

    //void OnTriggerExit (collider activator) THIS HAPPENS ON LEAVING THE CUBE

}

