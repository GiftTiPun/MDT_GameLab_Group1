using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class soundtest : MonoBehaviour
{
    //public bool starter;
    //public bool monzone;
    //Renderer sound;
    public static AudioSource BGM;
    public static float back = 5;
    public static float musicvolume=1f;
    public static float vol;


    // Start is called before the first frame update
    void Start()
    {
        BGM = GetComponent<AudioSource>();
        BGM.Play();
    }
    //private void Update()
    //{
    //    BGM.volume = musicvolume;
    //}
    //public static void Setvolume()
    //{
    //    musicvolume = vol;
    //}

    


}
