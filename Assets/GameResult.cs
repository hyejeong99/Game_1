using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Globalization;
using System.Threading;

public class GameResult : MonoBehaviour
{
    private int highScore;
    public Text resultTime;
    public Text bestTime;
    public GameObject resultUI;
 
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highScore = 999;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Goal.goal)//골 지점 도착시
        {
            resultUI.SetActive(true);
            int result = Mathf.FloorToInt(Timer.time);
            resultTime.text = "ResultTime:" + result;
            bestTime.text = "BestTime:" + highScore;
            if (highScore > result)
            {
                PlayerPrefs.SetInt("HighScore", result);
            }
        }
        if (Score.score >= 100)
        {
            Goal.goal = true;
            resultUI.SetActive(true);
            int result = Mathf.FloorToInt(Timer.time);
            resultTime.text = "ResultTime:" + result;
            bestTime.text = "BestTime:" + highScore;
            if (highScore > result)
            {
                PlayerPrefs.SetInt("HighScore", result);
            }
        }
    }
    public void OnRetry()//재시작버튼
    {
        //resultUI.SetActive(false);
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name);
        Goal.goal = false;
    }
   
    public void OnNext()//다음 스테이지 버튼
    {
        //resultUI.SetActive(false);
        SceneManager.LoadScene("Start2");
        Goal.goal = false;
    }
    public void OnEnd()//end 버튼
    {
        //resultUI.SetActive(false);
        SceneManager.LoadScene("End");
        Goal.goal = false;
    }
}
