using UnityEngine;
using System.Collections;

using UnityEngine.UI;



public class timerScript : MonoBehaviour {

    public Transform player;
    public Text uiText;

    // Update is called once per frame
    void Update () {
      int timePassed = (int) Time.time; //use timesincelevelload
      uiText.text = "the timer is " + timePassed.ToString();
        
        if( timePassed < 63 )
        {
            player.localScale += new Vector3(-.025f, -.025f, -.025f) * Time.deltaTime;
        }
       


	}
}
