using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class StoneAi : MonoBehaviour
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
        anim.SetTrigger("Idle");

    }


    void Update()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= activeDist)
        {
            anim.SetTrigger("IsMoving");
            navMesh.destination = player.position;
            

        }
        
        else if (dist > activeDist)
        {
            navMesh.destination = spawn.position;
            anim.SetTrigger("Idle");
        }

    }
}