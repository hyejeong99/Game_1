using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class UpScore : MonoBehaviour
{
    public static float score;
    void Start()
    {
        score = 0;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")//플레이어와 닿았다면
        {
            Destroy(gameObject);//사라지기
            score += 15;
        }
    }

}
