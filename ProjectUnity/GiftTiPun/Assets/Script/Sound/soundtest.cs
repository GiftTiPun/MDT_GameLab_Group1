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


    //public AudioClip bgm;
    //public AudioClip fight;


    // Start is called before the first frame update
     void Start()
    {
        //starter = true;
        //monzone = false;
        //sound = GetComponent<Renderer>();
        //sound.enabled = true;
        BGM = GetComponent<AudioSource>();
        BGM.Play();
    }
   
}
