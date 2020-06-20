using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startgame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        PauseMenu pause = GameObject.Find("CanvasForpause").GetComponent<PauseMenu>();
        pause.IsPause = true;
        GameObject.Find("Main Camera").GetComponent<camerarotation1>().enabled = false;
        Cursor.visible = true;
    }

    
}
