using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    public Transform player;
    public float activeDist;
    private NavMeshAgent navMesh;
    public Transform spawn;


    // Start is called before the first frame update
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= activeDist)
        {
            navMesh.destination = player.position;
        }
        else if (dist > activeDist)
        {
            navMesh.destination = spawn.position;
        }
    }
}