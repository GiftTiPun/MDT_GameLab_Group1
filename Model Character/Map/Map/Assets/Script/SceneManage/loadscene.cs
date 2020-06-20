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
    float progress = 0f;

    private void Start()
    {
        loadbar = GetComponent<Slider>();
        StartCoroutine(Load(1));
    }
    IEnumerator Load (int scene)
    {
        operation = SceneManager.LoadSceneAsync(scene);
        operation.allowSceneActivation = false;

        while( !operation.isDone)
        {
            progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);
            

            if ( operation.progress >= 0.9f )
            {
                Invoke("nextscene", 5f); 
            }
            yield return null;
        }
    }

    private void nextscene()
    {
        operation.allowSceneActivation = true;

    }
    private void Update()
    {
        loadbar.value = progress;
    }
}
