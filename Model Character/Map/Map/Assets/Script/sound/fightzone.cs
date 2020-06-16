using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightzone : MonoBehaviour
{
    public static AudioSource monfight;
    // Start is called before the first frame update

    void Start()
    {
        monfight = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            BGM.back = 0;
            BGM.bgm.volume = 0f;
            monfight.volume = 0.1f;
            monfight.Play();
        }
    }
}
