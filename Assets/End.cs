using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public GameObject endUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.time>60)//1분 지나면
        {
            endUI.SetActive(true);

        }
    }
    public void OnRetry()//재시작버튼
    {
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name);
    }
}
