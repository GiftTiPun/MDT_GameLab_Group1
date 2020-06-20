﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneAttack : MonoBehaviour
{
    public float damage = -5f;
    public float Cooldown;
    public float TimetoAtk = 0f;
    public AudioSource hit;
    public GameObject body;
    Animator anim;
    public float monvolume = 1f;



    void Start()
    {
        TimetoAtk = Cooldown;
        hit = GetComponent<AudioSource>();
        anim = body.GetComponent<Animator>();
        

    }

    void OnTriggerStay(Collider other)
    {
        

        if (other.gameObject.tag == "Player")
        {
            anim.SetTrigger("IsAttack");
            if (TimetoAtk < 0f)
            {
                TimetoAtk = 0f;
                

            }
            if (TimetoAtk == 0f)
            {
                
                PlayerHealth1 Phealth = GameObject.Find("player").GetComponent<PlayerHealth1>();
                Phealth.adjustcurrenthealth(damage);
                hit.volume = 0.1f;
                hit.Play();
                TimetoAtk = Cooldown;
                
                



            }
            if (TimetoAtk > 0f)
            {
                TimetoAtk -= Time.deltaTime;
               
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        TimetoAtk = Cooldown;
       

    }

    void Update()
    {
        hit.volume = monvolume;
    }
    public void SetVolume(float vol)
    {
        monvolume = vol;
    }
}
