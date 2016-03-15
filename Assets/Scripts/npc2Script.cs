using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class npc2Script : MonoBehaviour
{

    public Transform player;
    public Transform npc;
    public Text uiText;
    public Text uiText2;
    public AudioSource talkingSound;



    // Update is called once per frame
    void Update()
    {
        bool spottedPlayer = false;

        if ((player.position - npc.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space))
        {
            spottedPlayer = true;
            Debug.Log("detected2");
            talkingSound.PlayOneShot(talkingSound.clip, 1f);
            uiText2.text = "Oh, are you lost? Looking for your parents?\nIf you ask around, \nI'm sure someone might have an idea.";

        }


    }
}

       