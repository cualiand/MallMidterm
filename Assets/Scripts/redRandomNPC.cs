using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class redRandomNPC : MonoBehaviour
{


    public Transform player;
    public Transform npc;
    public Text uiText;
    public Text uiText2;
    public int timePassed;
    public float randomNumber;
    public AudioSource talkingSound;

    // Use this for initialization
    void Start()
    {
        randomNumber = Random.value;
        Debug.Log(randomNumber);
    }

    // Update is called once per frame
    void Update()
    {
        int timePassed = (int)Time.timeSinceLevelLoad;
        if ((player.position - npc.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space) && timePassed <= 30)
        {
            talkingSound.PlayOneShot(talkingSound.clip, 1f);
            if (randomNumber * 100f < 10f)
            {
                uiText2.text = "Poor kid. Looks like he's lost.";
            }
            if (randomNumber * 100f <= 20f && randomNumber * 100f > 10f)
            {
                uiText2.text = "I wonder where this kid's parents are?";
            }
            if (randomNumber * 100f <= 30f && randomNumber * 100f > 20f)
            {
                uiText2.text = "Hey, are you okay? Do you need help?";
            }
            if (randomNumber * 100f <= 40f && randomNumber * 100f > 30f)
            {
                uiText2.text = "Oh, they have a sale at the \n[insert clothing store] today!";
            }
            if (randomNumber * 100f <= 50f && randomNumber * 100f > 40f)
            {
                uiText2.text = "Dude, have you seen the new Call of Duty? \nIt looks sick, bro!";
            }
            if (randomNumber * 100f <= 60f && randomNumber * 100f > 50f)
            {
                uiText2.text = "Come get your free samples here!";
            }
            if (randomNumber * 100f <= 70f && randomNumber * 100f > 60f)
            {
                uiText2.text = "Did you see what she said on her twitter? \nShe's a total jerk!";
            }
            if (randomNumber * 100f <= 80f && randomNumber * 100f > 70f)
            {
                uiText2.text = "This mall is pretty drab looking.";
            }
            if (randomNumber * 100f <= 90f && randomNumber * 100f > 80f)
            {
                uiText2.text = "So where's the exit again?";
            }
            if (randomNumber * 100f <= 100f && randomNumber * 100f > 90f)
            {
                uiText2.text = "Where is my kid? You're not my kid.";
            }
            //todo- convert this to switchcase if possible
        }
        if ((player.position - npc.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space) && timePassed > 30)
        {
            talkingSound.PlayOneShot(talkingSound.clip, 1f);
            uiText2.text = "That person's too scary to talk to...";
        }
    }
}
