using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class npcScript : MonoBehaviour {

    public Transform player;
    public Transform npc;
    public Text uiText;
    public int timePassed;
    public bool spottedPlayer;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        timePassed = (int)Time.time;
        if ((player.position - npc.position).magnitude < 5f) {                                     //&& timePassed <= 5)  {
            uiText.text = "the timer is " + timePassed.ToString() + "\n\ni spotted the player!";
            spottedPlayer = true;
        }
        else if ((player.position - npc.position).magnitude < 5f) //&& timePassed > 5)
            {
                uiText.text = "the timer is " + timePassed.ToString() + "\n\nit's too late to talk!";
            }
        else
        {
               //uiText.text = "the timer is " + timePassed.ToString();
                spottedPlayer = false;
            }
        }
    }
