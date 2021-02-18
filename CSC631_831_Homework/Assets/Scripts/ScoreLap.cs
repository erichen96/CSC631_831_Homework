
using UnityEngine;
using UnityEngine.UI;

public class ScoreLap : MonoBehaviour
{
    public Text scoreText;

    public GameObject endScore;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = endScore.GetComponent<EndTrigger>().score.ToString();
        
    }
}
