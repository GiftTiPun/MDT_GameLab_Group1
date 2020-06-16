using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memozone : MonoBehaviour
{
    public static AudioSource memo;
    // Start is called before the first frame update

    void Start()
    {
        memo = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            BGM.back = 0;
            BGM.bgm.volume = 0f;
            memo.volume = 0.1f;
            memo.Play();
        }
    }
}
