using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class GemcanvasDestroyer : MonoBehaviour
{
    public GameObject GemCanvas;


    private void Update()
    {
        Invoke("Destroygemcanvas", 3f);
    }
    
    public void Destroygemcanvas()
    {
        Destroy(GemCanvas);
    }

}
