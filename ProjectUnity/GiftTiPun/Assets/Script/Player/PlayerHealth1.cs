using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth1 : MonoBehaviour
{
    public float player_max_health = 100;
    public float player_current_health;
    public GameObject body;
    public HpBar healthBar;
   
    
    private void Start()
    {
        player_current_health = player_max_health;
        healthBar.SetMaxHealth(player_max_health);
        
    }
    public void adjustcurrenthealth(float adj)
    {
        player_current_health += adj;

        if (player_current_health <= 0)
        {
            player_current_health = 0;                      
        }
        if (player_current_health > player_max_health)
        {
            player_current_health = player_max_health;
        }
     
    }
    public void changescene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    //คอมเม้นไรดี
    void Update()
    {
        healthBar.SetHealth(player_current_health);
        adjustcurrenthealth(0);
        if (player_current_health <= 0)
        {
            changescene("GameOver");
        }
    }

}
