using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrologueToLoad : MonoBehaviour
{

    public void ToLoad()
    {
        SceneManager.LoadScene("LoadScene");
    }

    public void Update()
    {
        Invoke("ToLoad",11.5f);
    }
}

