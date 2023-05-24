using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
    public delegate void ScoreUpdate (int newScore);
    public static event ScoreUpdate OnScoreUpdated;

    private static Game instance;
    private int score;
    [SerializeField] private TextMeshProUGUI scoreText;

    public static Game InstanceGet()
    {
        return instance;
    }

    private void Awake()
    {
       instance= this;
    }

    private void Start()
    {
        UpdateScoreText();
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        UpdateScoreText();
        OnScoreUpdated?.Invoke(score);
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}