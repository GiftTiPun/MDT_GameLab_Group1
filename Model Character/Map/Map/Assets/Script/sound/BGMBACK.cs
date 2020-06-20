﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMBACK : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" & BGM.back == 0)
        {
            fightzone.monfight.volume = 0f;
            memozone.memo.volume = 0f;
            BGM.bgm.volume = 0.4f;
            BGM.back = 5;
        }
    }
}
