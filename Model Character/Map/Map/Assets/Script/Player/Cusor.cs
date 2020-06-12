using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cusor : MonoBehaviour
{
    public void Cursorfck()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
