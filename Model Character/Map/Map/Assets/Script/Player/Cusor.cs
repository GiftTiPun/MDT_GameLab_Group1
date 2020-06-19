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
   
}
