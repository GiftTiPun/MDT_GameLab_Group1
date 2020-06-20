using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool IsPause = false;
    public GameObject PauseUI;
    

    public void Start()
    {
       
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
       
    }
    public void Pause()
    {
        GameObject.Find("Main Camera").GetComponent<camerarotation1>().enabled = false;
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
        
        IsPause = true;
    }
    public void Resume()
    {
        GameObject.Find ("Main Camera").GetComponent<camerarotation1>().enabled = true;
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        IsPause = false;
    }
}
