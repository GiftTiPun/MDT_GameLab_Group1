using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChagetoPlay : MonoBehaviour
{
    public void changescene(string scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1f;
        
        
    }
}
