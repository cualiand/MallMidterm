using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hint1NPC : MonoBehaviour
{

    public Transform player;
    public Transform npc;
    public Text uiText;
    public Text uiText2;
    public int timePassed;




    // Update is called once per frame
    void Update()
    {
        if ((player.position - npc.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space))
        {
            uiText2.text = "Looking for parents? Try checking the exits.";
        }
    }
}
