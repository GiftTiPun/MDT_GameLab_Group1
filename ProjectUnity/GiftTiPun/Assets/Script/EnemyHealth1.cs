using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyHealth1 : MonoBehaviour
{
    public float enemy_max_health = 50;
    public float enemy_current_health = 50;
    public GameObject body;

    public void adjustcurrenthealth(float adj)
    {
        enemy_current_health += adj;

        if (enemy_current_health <= 0)
        {
            enemy_current_health = 0;
            Destroy(body);
        }
        if (enemy_current_health > enemy_max_health)
        {
            enemy_current_health = enemy_max_health;
        }
        if (enemy_max_health < 1)
        {
            enemy_max_health = 1;
        }
    }

    void Update()
    {
        adjustcurrenthealth(0);
    }
}
