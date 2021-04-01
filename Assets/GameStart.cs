using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject ruleButton;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnRuleStart()
    {
        ruleButton.SetActive(false);
    }
    public void OnStage1()//stage1으로
    {
        SceneManager.LoadScene("Stage_1");
    }
    public void OnStage2()//stage1으로
    {
        SceneManager.LoadScene("Stage_2");
    }
}
