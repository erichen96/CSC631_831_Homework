using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public AudioClip sound;
    void Start(){
        //disable playOnAwake so that it does not play on scene start, but is active for collision play
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sound;
    }

    public int score = 0;
    void OnTriggerEnter(){
        Debug.Log("Entered the Goal");
        score++;
        Debug.Log("Current Score: " + score);
        GetComponent<AudioSource>().Play();
    }
}
