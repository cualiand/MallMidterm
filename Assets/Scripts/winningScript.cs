using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class winningScript : MonoBehaviour {

    public Transform player;
    public Transform winningNPC;
    public Text uiText;
    public int timePassed;
    public bool spottedPlayer;


    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        timePassed = (int)Time.time;
        if ((player.position - winningNPC.position).magnitude < 5f && timePassed <= 5)
        {
            spottedPlayer = true;
            uiText.text = "the timer is " + timePassed.ToString() + "\n\nI found my parents!";
        }
        
        else
        {
            uiText.text = "the timer is " + timePassed.ToString();
        }
    }
}

