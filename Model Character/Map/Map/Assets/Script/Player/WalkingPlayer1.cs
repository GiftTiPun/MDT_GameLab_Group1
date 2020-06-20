using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingPlayer1 : MonoBehaviour
{
    public float SpeedMovement = 3.0f;
    public Camera cameramain;



    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * SpeedMovement;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * SpeedMovement;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * SpeedMovement;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * SpeedMovement;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.position.y <= 0.8f)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 350);
            }
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            SpeedMovement = 7f;
        }
        else
        {
            SpeedMovement = 3f;
        }
        Quaternion rotate = Quaternion.Euler(0, cameramain.transform.rotation.eulerAngles.y-90, 0);
        transform.rotation = rotate;

    }
    
}
