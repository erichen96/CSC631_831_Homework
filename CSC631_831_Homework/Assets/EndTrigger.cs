using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public int score = 0;
    void OnTriggerEnter(){
        Debug.Log("Entered the Goal");
        score++;
        Debug.Log("Current Score: " + score);
    }
}
