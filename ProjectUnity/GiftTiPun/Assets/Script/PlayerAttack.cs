using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attack_Power = -10f;
    public float TimebetweenAttack = 0.5f;
    GameObject target;
    
    


    private void OnCollisionStay(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            EnemyHealth Ehealth = other.gameObject.GetComponent<EnemyHealth>();
            Ehealth.adjustcurrenthealth(attack_Power);
            
        }
        
    }
    private void Attack()
    {
        Debug.Log("Attack");
        
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
            
        }
    }
    
}
