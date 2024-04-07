using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int currentScore;
    public int bestScore;
    
    private static ScoreManager instance;
    
    public static ScoreManager Instance
    {
        get => instance;
    }

    public static ScoreManager GetInstance()
    {
        if (instance == null)
        {
            instance = new ScoreManager();
        }

        return instance;
    }
}
