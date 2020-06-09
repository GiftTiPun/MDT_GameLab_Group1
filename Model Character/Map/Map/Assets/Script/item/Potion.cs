using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    public GameObject body;
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            PlayerHealth1 PHealth = GameObject.Find("player").GetComponent<PlayerHealth1>();
            PHealth.adjustcurrenthealth(10f);
            Destroy(body);
        }
    }
}
