using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovements : MonoBehaviour
{
    Transform player;               // Reference to the player's position.
    PlayerHealth1 playerHealth;      // Reference to the player's health.
    EnemyHealth1 enemyHealth;        // Reference to this enemy's health.
    UnityEngine.AI.NavMeshAgent nav;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth1>();
        enemyHealth = GetComponent<EnemyHealth1>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        // If the enemy and the player have health left...
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            // ... set the destination of the nav mesh agent to the player.
            nav.SetDestination(player.position);
        }
        // Otherwise...
        else
        {
            // ... disable the nav mesh agent.
            nav.enabled = false;
        }
    }
}
