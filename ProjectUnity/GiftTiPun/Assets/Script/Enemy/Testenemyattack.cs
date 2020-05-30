using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testenemyattack : MonoBehaviour
{
    public float damage = -5f;
    public float Cooldown;
    public float TimetoAtk = 0f;
    
    void Start()
    {
        TimetoAtk = Cooldown;
    }
  
    void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == "Player" )
        {
            if (TimetoAtk < 0f)
            {
                TimetoAtk = 0f;
            }
            if (TimetoAtk == 0f)
            {
                PlayerHealth1 Phealth = other.gameObject.GetComponent<PlayerHealth1>();
                Phealth.adjustcurrenthealth(damage);
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
        
    }
}
