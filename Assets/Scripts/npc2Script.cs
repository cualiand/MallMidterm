using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class npc2Script : MonoBehaviour
{

    public Transform player;
    public Transform npc;
    public Text uiText;
    public Text uiText2;
    public int timePassed;



    // Update is called once per frame
    void Update()
    {
        bool spottedPlayer = false;

        if ((player.position - npc.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space))
        {
            spottedPlayer = true;
            Debug.Log("detected2");
            uiText2.text = "i also spotted the player!";
        }


    }
}

       