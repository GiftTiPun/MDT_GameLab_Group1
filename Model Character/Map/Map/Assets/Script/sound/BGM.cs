using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public static AudioSource bgm;
    public static float back = 5;
    // Start is called before the first frame update
    void Start()
    {
        bgm = GetComponent<AudioSource>();
        bgm.volume = 0.4f;
        bgm.Play();
    }
    

    // Update is called once per frame
}
