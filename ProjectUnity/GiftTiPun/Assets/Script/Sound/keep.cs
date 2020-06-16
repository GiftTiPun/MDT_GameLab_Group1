using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class keep : MonoBehaviour
{
    //public bool starter;
    //public bool monzone;
    public static AudioSource monfight;
    //public AudioSource bgm;
    //public AudioClip bgm;
    //public AudioClip fight;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        monfight = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            monfight.Play();
            monfight.volume = 0.1f;
            soundtest.BGM.volume = 0f;
            soundtest.back = 0;
        }
    }
}
