using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menusound : MonoBehaviour
{
    public  AudioSource menubgm;
    public float vl=1f;
    // Start is called before the first frame update
    void Start()
    {
        menubgm = GetComponent<AudioSource>();
    }
    void Update()
    {
        menubgm.volume = vl;
    }
    public void SetVolume(float vol)
    {
        vl = vol;
    }
}
