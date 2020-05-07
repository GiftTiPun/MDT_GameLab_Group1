using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingPlayer : MonoBehaviour
{
    public float SpeedMovement = 3.0f;
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float X = 0.0f;
    private float Y = 0.0f;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * SpeedMovement;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * SpeedMovement;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * SpeedMovement;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * SpeedMovement;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.TransformDirection(Vector3.up) *2* Time.deltaTime * SpeedMovement;
        }
        
    }
}
