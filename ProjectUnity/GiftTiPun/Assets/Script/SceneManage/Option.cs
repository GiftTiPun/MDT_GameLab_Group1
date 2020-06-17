using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public static float musicvolume = 1f;
    void Start()
    {
        soundtest.BGM.volume = musicvolume;
    }

    // Update is called once per frame
    void Setvolume(float vol)
    {
        musicvolume = vol;
    }
}
