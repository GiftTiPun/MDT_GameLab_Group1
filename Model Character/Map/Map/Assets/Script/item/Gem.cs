using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public GameObject body;
    public float power;
    public GameObject GemCanvas;
    public AudioSource wink;
    
    private void OnTriggerEnter(Collider other)
    {
        wink = GameObject.Find("WINK").GetComponent<AudioSource>();
        if (other.gameObject.tag == "Player")
        {
            PlayerAttack PAttack = GameObject.Find("PlayerRangeAttack").GetComponent<PlayerAttack>();
            wink.Play();
            PAttack.attack_Power += power;
            Destroy(body);
            GemCanvas.SetActive(true);
            
            
        }
    }
    

}