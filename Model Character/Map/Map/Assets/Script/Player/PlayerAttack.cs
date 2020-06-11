using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attack_Power = -10f;
    public float TimetoAtk = 0.0f;
    public float Cooldown = 0.5f;
    

    private void OnTriggerStay(Collider other)
    {
        if (TimetoAtk < 0f)
        {
            TimetoAtk = 0f;
        }
        if (TimetoAtk > 0f)
        {
            TimetoAtk -= Time.deltaTime;
        }
        if (other.gameObject.tag == "enemy" && Input.GetMouseButtonDown(0))
        { 
            
            if (TimetoAtk == 0f)
            {
                EnemyHealth1 Ehealth = other.gameObject.GetComponent<EnemyHealth1>();
                Ehealth.adjustcurrenthealth(attack_Power);
                TimetoAtk = Cooldown;
            }
        }
        
    }
    
   
  

    void Start()
    {
        TimetoAtk = Cooldown;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Attack");

        }
    }
    
}
