using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attack_Power = 10f;
    public float attack_Range = 15f;
    public float TimebetweenAttack = 0.5f;
    public GameObject target;
    private Vector3 targetposition;
    
    

    private void Attack()
    {
        Debug.Log("Attack");
    }

    private void Start()
    {
        target = GameObject.FindWithTag("enemy");
        targetposition = target.transform.position;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }
    
}
