using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //important

public class titleScreen : MonoBehaviour {

    public static bool useNightmareMode = false; //static means this variable lives in the code instead of a game object, and persists beyond a scene change
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            //loading the main game scene
            SceneManager.LoadScene(1); //loads scene number one in your build settings
        }
        
        if (Input.GetKeyDown(KeyCode.N))
        {
            useNightmareMode = !useNightmareMode; //this reverses the boolean state. 
        }
	}
}
