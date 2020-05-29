using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth1 : MonoBehaviour
{
    public float player_max_health = 100;
    public float player_current_health = 100;
    public GameObject body;

    public void adjustcurrenthealth(float adj)
    {
        player_current_health += adj;

        if (player_current_health <= 0)
        {
            player_current_health = 0;
            Destroy(body);
        }
        if (player_current_health > player_max_health)
        {
            player_current_health = player_max_health;
        }
        if (player_max_health < 1)
        {
            player_max_health = 1;
        }
    }
    //คอมเม้นไรดี
    void Update()
    {
        adjustcurrenthealth(0);
    }

}
