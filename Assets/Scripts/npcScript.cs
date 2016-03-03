using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class npcScript : MonoBehaviour {

    public Transform player;
    public Transform npc;
    public Text uiText;
    public Text uiText2;
    public int timePassed;
    
    

    // Update is called once per frame
    void Update() {
        int timePassed = (int)Time.timeSinceLevelLoad; //use timesincelevelload
        bool spottedPlayer = false;

        if ((player.position - npc.position).magnitude <= 5f && Input.GetKeyDown(KeyCode.Space)) 
        {
            spottedPlayer = true;
            Debug.Log("detected");
            if (timePassed <= 5)
            {
                uiText2.text = "i spotted the player!";
            }
            else
            {
                uiText2.text = "i'm too afraid to talk!";
            }

        }

        
        
       
     
      
       
      
   
        }
    }
