using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class keep : MonoBehaviour
{
    //public bool starter;
    //public bool monzone;
    public AudioSource monfight;
    //public AudioClip bgm;
    //public AudioClip fight;


    // Start is called before the first frame update
    void Start()
    {
        //starter = true;
        //monzone = false;
        monfight = GetComponent<AudioSource>();
        monfight.Play();
    }
}
