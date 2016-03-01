using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restartScene : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //this reloads the scene
        }
	}
}
