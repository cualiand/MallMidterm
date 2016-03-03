using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class randomNPCScript : MonoBehaviour {


    public Transform player;
    public Transform npc;
    public Text uiText;
    public Text uiText2;
    public int timePassed;
    public float randomNumber;

    // Use this for initialization
    void Start () {
        randomNumber = Random.value;
        Debug.Log(randomNumber);
	}
	
	// Update is called once per frame
	void Update () {
        if ((player.position - npc.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space))
        {
            if (randomNumber * 100f < 50f)
            {
                uiText2.text = "This is message number 1.";
            }
            if (randomNumber * 100f >= 50f)
            {
                uiText2.text = "This is message number 2.";
            }

        }
    }
}
