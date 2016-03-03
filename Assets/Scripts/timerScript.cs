using UnityEngine;
using System.Collections;

using UnityEngine.UI;



public class timerScript : MonoBehaviour {

    public Transform player;
    public Text uiText;
    public int crazyRepeatCount;


    void Start()
    {
        GetComponent<winningScript>();
    }

    // Update is called once per frame
    void Update () {
      int timePassed = (int) Time.timeSinceLevelLoad; //use timesincelevelload
      uiText.text = "the timer is " + timePassed.ToString();
        
        if( timePassed < 63 )
        {
            player.localScale += new Vector3(-.025f, -.025f, -.025f) * Time.deltaTime;
        }
        

        
        if (timePassed > 10)
        {
            uiText.text = "the timer is " + timePassed.ToString() + "\nI wonder where my parents went...";
        }
        if (timePassed > 20)
        {
            uiText.text = "the timer is " + timePassed.ToString() + "\nMom? Dad? This isn't funny...";
        }
        if (timePassed > 30)
        {
            uiText.text = "the timer is " + timePassed.ToString() + "\nGuys? I really want to go home now,\npretty please?";
        }
        if (timePassed > 40)
        {
            uiText.text = "the timer is " + timePassed.ToString() + "\nThis isn't funny... \nwhy is everything getting bigger?";
        }
        if (timePassed > 50)
        {
            uiText.text = "the timer is " + timePassed.ToString() + "\nDid they forget about me? \nI don't have a phone to call them, and\nI'm too scared to ask.";
        }

        if (timePassed > 60)
        {
            uiText.text = "the timer is " + timePassed.ToString() + "\nOkay, just calm down. They've got \nto be around here somewhere, \nbut I can't see them with \nall these giant people.";
        } 

        if (timePassed >= 3 && timePassed % 3 == 0)
        {
            crazyRepeatCount++;
          //todo- finish this repeat stuff
        }
      




    }
}
