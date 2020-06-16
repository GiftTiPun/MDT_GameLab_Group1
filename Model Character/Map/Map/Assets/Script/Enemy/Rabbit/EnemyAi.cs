using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    public Transform player;
    public float activeDist;
    private NavMeshAgent navMesh;
    public Transform spawn;
    public GameObject body;
    Animator anim;


    
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        anim = body.GetComponent<Animator>();
        anim.SetFloat("Speed", 0f);

    }

    
    void Update()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= activeDist)
        {
            navMesh.destination = player.position;
            anim.SetFloat("Speed", 1f);
            
        }
        else if (dist > activeDist && body.transform.position == spawn.transform.position)
        {
            anim.SetFloat("Speed", 0f);
            
   
        }
        else if (dist > activeDist)
        {
            navMesh.destination = spawn.position;
            //anim.SetFloat("Speed", 1f);
        }

    }
}