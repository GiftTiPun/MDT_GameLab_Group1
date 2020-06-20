using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChangeS : MonoBehaviour
{
    public AudioSource slimeatk;
    public float slimevolume = 1f;
    void Start()
    {
        slimeatk = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        slimeatk.volume = slimevolume;
    }
    public void SetVolume(float vol)
    {
        slimevolume = vol;  
    }
}
