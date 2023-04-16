using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private Text scoreText;

    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void ScoreIncrease(int newScore)
    {
        score += newScore;
    }
}
