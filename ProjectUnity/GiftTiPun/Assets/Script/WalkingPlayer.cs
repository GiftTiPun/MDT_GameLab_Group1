using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingPlayer : MonoBehaviour
{
    public float SpeedMovement = 3.0f;
    public Camera cameramain; 
    


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
        Quaternion rotate = Quaternion.Euler(0, cameramain.transform.rotation.eulerAngles.y, 0);
        transform.rotation = rotate;
        
    }
}
