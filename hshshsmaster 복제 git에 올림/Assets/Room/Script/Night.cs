﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Night : MonoBehaviour
{
    public GameObject NightPanel;
    private bool isNight = false;
    private float timer;

    void Start()
    {
        Random.InitState(System.DateTime.Now.Millisecond);
        if (Random.Range(1, 3) == 1)
        {
            isNight = true;
            Debug.Log("눈송늦잠엔딩[5]");
        }
        NightPanel.SetActive(isNight);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (isNight && timer > 10)
        {
            //포탈 사용 X
            Debug.Log("늦잠자서 지각엔딩... ㅎㅎ...");
            EndArray.setEndingArray(5, true);
        }
    }
}
