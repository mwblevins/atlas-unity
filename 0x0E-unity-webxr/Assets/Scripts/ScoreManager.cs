using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
            if (score == 10)
            {
                scoreText.text = "STRIKE";
            }
        }
    }

    public void IncrementScore(int points)
    {
        score += points;
        UpdateScoreText();
    }
}
