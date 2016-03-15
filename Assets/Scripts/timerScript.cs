using UnityEngine;
using System.Collections;

using UnityEngine.UI;



public class timerScript : MonoBehaviour {

    public Transform player;
    public Text uiText;
    public int crazyRepeatCount;
    public AudioSource mallSounds; //todo- make mall volume increase, add sounds to talking for each npc, add sound for failing to talk, custom font, make windows more understandable, add exit signs
    public float volume;



    void Start()
    {
        GetComponent<winningScript>();
    }

    // Update is called once per frame
    void Update () {
      int timePassed = (int) Time.timeSinceLevelLoad; //use timesincelevelload
      int clockTime = timePassed;

        uiText.text = "It's been " + clockTime.ToString() + " minutes since you were lost";




        /*if (timePassed < 60 && timePassed < 10)
        {
            uiText.text = "The time is 5:0" + clockTime.ToString();
        }
      else if (timePassed < 60 && timePassed >= 10) 
        {
            uiText.text = "The time is 5:" + clockTime.ToString();
        }
      else if (timePassed >= 60 && timePassed < 70 ) {
            clockTime = clockTime;
            clockTime -= 60;
            uiText.text = "The time is 6:" + clockTime.ToString();
        }
      else if (timePassed >= 71)
        {
            uiText.text = "The time is 6:0" + clockTime.ToString(); //todo- fix clock being permanantly 5:00
        }
        */
      
      
        
        if( timePassed < 63 )
        {
            player.localScale += new Vector3(-.005f, -.005f, -.005f) * Time.deltaTime;
        }

        

        
        if (timePassed > 10)
        {
            uiText.text = "It's been " + clockTime.ToString() + " minutes since you were lost" + "\nI wonder where they went...";
        }
        if (timePassed > 20)
        {
            uiText.text = "It's been " + clockTime.ToString() + " minutes since you were lost" + "\nMom? Dad? This isn't funny...";
        }
        if (timePassed > 30)
        {
            uiText.text = "It's been " + clockTime.ToString() + " minutes since you were lost" + "\nGuys? I really want to go home now,\npretty please?";
        }
        if (timePassed > 40)
        {
            uiText.text = "It's been " + clockTime.ToString() + " minutes since you were lost" + "\nThis isn't funny... \nwhy is everything getting bigger?";
        }
        if (timePassed > 50)
        {
            uiText.text = "It's been " + clockTime.ToString() + " minutes since you were lost" + "\nDid they forget about me?";
        }

        if (timePassed > 60)
        {
            uiText.text = "It's been " + clockTime.ToString() + " minutes since you were lost" + "\nOkay, just calm down.";
        } 

     
      




    }
}
