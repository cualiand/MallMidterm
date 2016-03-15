using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hint2NPC : MonoBehaviour
{

    public Transform player;
    public Transform npc;
    public Text uiText;
    public Text uiText2;
    public int timePassed;
    public AudioSource talkingSound;




    // Update is called once per frame
    void Update()
    {
        if ((player.position - npc.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space))
        {
            talkingSound.PlayOneShot(talkingSound.clip, 1f);
            uiText2.text = "I just saw some parents rush through here!";
        }
    }
}
