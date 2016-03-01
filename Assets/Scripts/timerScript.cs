using UnityEngine;
using System.Collections;

using UnityEngine.UI;



public class timerScript : MonoBehaviour {

    public Transform player;

    // Update is called once per frame
    void Update () {
        ////int timePassed = (int) Time.time;
      //  GetComponent<Text>().text = "the timer is " + timePassed.ToString();

        player.localScale += new Vector3(-.03f, -.03f, -.03f) * Time.deltaTime;
	}
}
