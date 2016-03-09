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
      int clockTime = timePassed;
      if (timePassed < 60 && timePassed < 10)
        {
            uiText.text = "The time is 5:0" + clockTime.ToString();
        }
      else if (timePassed < 60 && timePassed >= 10) 
        {
            uiText.text = "The time is 5:" + clockTime.ToString();
        }
      else if (timePassed >= 60 && timePassed < 70 ) {
            clockTime -= 60;
            uiText.text = "The time is 6:" + clockTime.ToString();
        }
      else if (timePassed >= 71)
        {
            uiText.text = "The time is 6:0" + clockTime.ToString(); //todo- fix clock being permanantly 5:00
        }
      
      
        
        if( timePassed < 63 )
        {
            player.localScale += new Vector3(-.025f, -.025f, -.025f) * Time.deltaTime;
        }
        

        
        if (timePassed > 10)
        {
            uiText.text = "The time is 5:" + clockTime.ToString() + "\nI wonder where my parents went...";
        }
        if (timePassed > 20)
        {
            uiText.text = "The time is 5:" + clockTime.ToString() + "\nMom? Dad? This isn't funny...";
        }
        if (timePassed > 30)
        {
            uiText.text = "The time is 5:" + clockTime.ToString() + "\nGuys? I really want to go home now,\npretty please?";
        }
        if (timePassed > 40)
        {
            uiText.text = "The time is 5:" + clockTime.ToString() + "\nThis isn't funny... \nwhy is everything getting bigger?";
        }
        if (timePassed > 50)
        {
            uiText.text = "The time is 5:" + clockTime.ToString() + "\nDid they forget about me?";
        }

        if (timePassed > 60)
        {
            uiText.text = "The time is 5:" + clockTime.ToString() + "\nOkay, just calm down.";
        } 

        if (timePassed >= 3 && timePassed % 3 == 0)
        {
            crazyRepeatCount++;
          //todo- finish this repeat stuff
        }
      




    }
}
