using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public static float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Goal.goal == false)//
        {
            time += Time.deltaTime;
        }
        int t = Mathf.FloorToInt(time);
        Text uiText = GetComponent<Text>();
        uiText.text = "Time: " + t;//실행시간 표시해주기
        if (Timer.time > 60)//1분 지나면
        {
            uiText.text = "over time";
        }

    }
}
