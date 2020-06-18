using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmonarea : MonoBehaviour
{
    float sound;
    //float keepfirst;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"& soundtest.back ==0)
        {
            
            keep.monfight.volume = 0f;
            soundtest.BGM.volume = 1f;
            soundtest.back = 5;
        }
        
    }
}