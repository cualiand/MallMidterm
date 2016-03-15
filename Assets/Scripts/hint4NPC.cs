using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hint4NPC : MonoBehaviour
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
        int timePassed = (int)Time.timeSinceLevelLoad;


        if ((player.position - npc.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space) && timePassed < 50)
        {
            talkingSound.PlayOneShot(talkingSound.clip, 1f);
            uiText2.text = "This place is under construction, kiddo. \nNothing here to play with.";
        }
        else if ((player.position - npc.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space) && timePassed > 50)
        {
            talkingSound.PlayOneShot(talkingSound.clip, 1f);
            uiText2.text = "This person is really scary!";
        }


    }
}
