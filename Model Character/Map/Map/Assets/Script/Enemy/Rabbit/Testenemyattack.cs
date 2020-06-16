using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testenemyattack : MonoBehaviour
{
    public float damage = -5f;
    public float Cooldown;
    public float TimetoAtk = 0f;
    public AudioSource hit;
    public GameObject body;
    Animator anim;


   
    void Start()
    {
        TimetoAtk = Cooldown;
        hit = GetComponent<AudioSource>();
        anim = body.GetComponent<Animator>();
        anim.SetBool("HitPlayer", false);
       
    }
  
    void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == "Player" )
        {
            if (TimetoAtk < 0f)
            {
                TimetoAtk = 0f;
                anim.SetBool("HitPlayer", false);
            }
            if (TimetoAtk == 0f)
            {
                PlayerHealth1 Phealth = GameObject.Find("player").GetComponent<PlayerHealth1>();
                Phealth.adjustcurrenthealth(damage);
                hit.volume = 0.1f;
                hit.Play();
                TimetoAtk = Cooldown;
                anim.SetBool("HitPlayer", true);

            }
            if (TimetoAtk > 0f)
            {
                TimetoAtk -= Time.deltaTime;
                anim.SetBool("HitPlayer", false);
            }
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        TimetoAtk = Cooldown;
    }
    
    void Update()
    {
        
    }
}
