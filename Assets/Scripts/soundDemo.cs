using UnityEngine;
using System.Collections;

public class soundDemo : MonoBehaviour {

    AudioSource laserSound;
    public AudioClip myExplosionSound; //use public for multiple clips


	// Use this for initialization
	void Start () {
        //GetComponent<AudioSource>().Play(); // this plays the audio upon start
        laserSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //laserSound.Play();
            laserSound.PlayOneShot(laserSound.clip, 0.5f); //this will make sounds not get interuptted by other sounds, at 50% volume
        }
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            laserSound.PlayOneShot(myExplosionSound, .5f);
        }

        if (Input.GetKeyDown(KeyCode.B)) //this is kinda bad
        {
            AudioSource.PlayClipAtPoint(myExplosionSound, new Vector3(2f, 0f, 0f), 1f);
        }
	}
}
