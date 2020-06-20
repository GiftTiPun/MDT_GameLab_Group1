using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutscene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Cutscene");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
