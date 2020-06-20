using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTutorial : MonoBehaviour
{
    public GameObject tutu;
    public void destroytutu()
    {
        Destroy(tutu);
        Time.timeScale = 1f;
        PauseMenu pause = GameObject.Find("CanvasForpause").GetComponent<PauseMenu>();
        pause.IsPause = false;
        GameObject.Find("Canvasfortutorial").GetComponent<Startgame>().enabled = false ;
        GameObject.Find("Main Camera").GetComponent<camerarotation1>().enabled = true;
    }
}
