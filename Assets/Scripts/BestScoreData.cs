using System;
using UnityEngine;

[Serializable]
public class BestScoreData
{
    [SerializeField] private int _bestScore;

    public BestScoreData(int bestScore)
    {
        _bestScore = bestScore;
    }

    public int BestScore { get => _bestScore; }
}
