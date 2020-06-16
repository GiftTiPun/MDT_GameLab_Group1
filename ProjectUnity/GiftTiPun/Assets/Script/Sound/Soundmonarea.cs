using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmonarea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"& soundtest.back ==0)
        {
            keep.monfight.volume = 0.1f;
            soundtest.BGM.volume = 1.5f;
            soundtest.back = 5;
        }
        if (keep.monfight.volume == 0.1f)
        {
            keep.monfight.volume = 0f;
        }
    }
}