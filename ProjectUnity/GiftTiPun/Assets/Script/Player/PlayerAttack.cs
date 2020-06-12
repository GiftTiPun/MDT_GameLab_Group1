using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attack_Power = -10f;
    public float TimebetweenAttack = 0.5f;
    GameObject target;
    Renderer rend;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "enemy" && Input.GetMouseButtonDown(0))
        {
            EnemyHealth1 Ehealth = other.gameObject.GetComponent<EnemyHealth1>();
            Ehealth.adjustcurrenthealth(attack_Power);

        }
    }
    
   
    private void Attack()
    {
        Debug.Log("Attack");
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    private void Start()
    {
        target = GameObject.FindWithTag("enemy");
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            rend.enabled = false;

        }
    }
    
}
