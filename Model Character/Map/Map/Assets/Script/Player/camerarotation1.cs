﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotation1 : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float X = 0.0f;
    private float Y = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        X += speedH * Input.GetAxis("Mouse X");
        Y -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(Y, X, 0.0f);

    }
}
