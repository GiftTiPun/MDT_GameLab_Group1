using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadscene : MonoBehaviour
{
    float countdown = 0f;
    public Slider loadbar;
    AsyncOperation operation;



   
    public void Start()
    {
        StartCoroutine(Load(1));
    }
    IEnumerator Load (int scene)
    {
        operation = SceneManager.LoadSceneAsync(scene);
        operation.allowSceneActivation = false;

        while( !operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);
            loadbar.value = progress;

            if (progress == 1f )
            {
                Debug.Log("invoke");
                operation.allowSceneActivation = false;
                Invoke("nextscene", 5f);           
                Debug.Log("Fin");
            }
            yield return null;
        }
    }

    public void nextscene()
    {
        operation.allowSceneActivation = true;

    }

   

}
