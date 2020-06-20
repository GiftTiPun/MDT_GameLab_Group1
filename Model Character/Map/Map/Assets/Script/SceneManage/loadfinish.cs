using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadfinish : MonoBehaviour
{
    public void ToLoad()
    {
        SceneManager.LoadScene("Finish");
    }

    public void Update()
    {
        Invoke("ToLoad", 17f);
    }
}
