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
    public AudioSource talkingSound;


    // Use this for initialization
    void Start () {
        canGoHome = false;
        
	}

    // Update is called once per frame
    void Update()
    {
        if ((player.position - winningNPC.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space))
        {
            talkingSound.PlayOneShot(talkingSound.clip, 1f);
            canGoHome = true;
            uiText2.text = "Phew, you found Mom and Dad! \nPress [H] to go home!";

        }

        if (canGoHome == true && Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene(2);
        }
    }
}

