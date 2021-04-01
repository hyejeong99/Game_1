using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static float score;

    void Start()
    {
        score = 0;
    }
    void Update()
    {
        score = Mathf.FloorToInt(UpScore.score);
        Text scoreText = GetComponent<Text>();
        scoreText.text = "score: " + score;//실행시간 표시해주기

    }
}


