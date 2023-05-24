using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    private Button button;
    private ScoreModi scoreModifier;

    private void Start()
    {
        button = GetComponent<Button>();
        scoreModifier = GetComponent<ScoreModi>();
        button.onClick.AddListener(IncrementScore);
    }

    private void IncrementScore()
    {
        int scoreIncrement = scoreModifier.GetScoreIncrement();
        Game.InstanceGet().IncrementScore(scoreIncrement);
    }
}
