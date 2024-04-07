using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    void Start()
    {
        Debug.Log(ScoreManager.GetInstance().currentScore = 10);
    }
}
