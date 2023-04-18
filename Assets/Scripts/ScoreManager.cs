using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    [SerializeField] private Text scoreText;
    [SerializeField] private int scoreIncrease = 1;
    private int score;

    private void Awake()
    {
        Instance = this;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void ScoreIncrease()
    {
        score += scoreIncrease;
        UpdateScore();
    }
}
