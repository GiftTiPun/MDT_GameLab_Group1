using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmonarea : MonoBehaviour
{
    Renderer rend;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider player)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        rend.enabled = false;
    }
}