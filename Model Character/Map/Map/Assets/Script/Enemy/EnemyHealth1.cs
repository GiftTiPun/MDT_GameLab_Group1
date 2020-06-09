using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyHealth1 : MonoBehaviour
{
    public float enemy_max_health = 50;
    public float enemy_current_health = 50;
    public GameObject body;
    

    public void adjustcurrenthealth(float adj)
    {
        enemy_current_health += adj;
        Score addscore = GameObject.Find("player").GetComponent<Score>(); //to use find gameobject that contain score of each level.

        if (enemy_current_health <= 0)
        {
            enemy_current_health = 0;
            Destroy(body);
            addscore.score++;

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
