using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrement : ScoreModi
{
    public int scoreIncrement;

    public override int GetScoreIncrement()
    {
        return scoreIncrement;
    }
}
