using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGem : MonoBehaviour
{
    public GameObject body;
    public float totalscore;
    public GameObject gem;
    public GameObject GemCanvas;
    public AudioSource wink;
    private void OnTriggerEnter(Collider other)
    {
        wink = GameObject.Find("WINK").GetComponent<AudioSource>();
        if (other.gameObject.tag == "Player")
        {
            PlayerHealth1 PHealth = GameObject.Find("player").GetComponent<PlayerHealth1>();
            wink.Play();
            PHealth.adjustcurrenthealth(100f);
            Destroy(body);
            GemCanvas.SetActive(true);
            
        }
        
    }
    public void AppearGem()
    {
        Score score = GameObject.Find("player").GetComponent<Score>();
        //to use find gameobject that contain score of each level and change statement in if to number of enemy in each level
        if (score.score >= totalscore)
        {
            gem.SetActive(true);
        }
    }
   
}
