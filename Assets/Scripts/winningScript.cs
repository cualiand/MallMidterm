using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winningScript : MonoBehaviour {

    public Transform player;
    public Transform winningNPC;
    public Text uiText;
    public Text uiText2;
    public bool spottedPlayer;
    static public bool canGoHome;


    // Use this for initialization
    void Start () {
        canGoHome = false;
        
	}

    // Update is called once per frame
    void Update()
    {
        if ((player.position - winningNPC.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space))
        {
            canGoHome = true;
            uiText2.text = "Congratz, you found your parents! \nPress [H] to go home!";

        }

        if (canGoHome == true && Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene(2);
        }
    }
}

