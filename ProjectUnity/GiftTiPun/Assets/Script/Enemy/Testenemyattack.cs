using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testenemyattack : MonoBehaviour
{
    public int hitCount = -5; //number of hits
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*void attack()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                hit.collider.gameObject.GetComponent<PlayerHealth1>().player_current_health -= 5f;
            }
        }
    }*/
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerHealth1 Phealth = other.gameObject.GetComponent<PlayerHealth1>();
            Phealth.adjustcurrenthealth(hitCount);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
