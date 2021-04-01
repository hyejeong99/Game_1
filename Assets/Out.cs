using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Out : MonoBehaviour
{
    void OnTriggerEnter(Collider col)//충돌 판정
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
