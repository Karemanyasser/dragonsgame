using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   Text scoreText;
    public static int scoreValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreUI();
    }
    void UpdateScoreUI() // to display score for the user 
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + scoreValue;
        }
    }
}