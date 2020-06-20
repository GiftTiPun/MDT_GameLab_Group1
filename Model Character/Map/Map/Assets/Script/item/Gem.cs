using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public GameObject body;
    public float power;
    public GameObject GemCanvas;
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            PlayerAttack PAttack = GameObject.Find("PlayerRangeAttack").GetComponent<PlayerAttack>();
            PAttack.attack_Power += power;
            Destroy(body);
            GemCanvas.SetActive(true);
            
            
        }
    }
    

}