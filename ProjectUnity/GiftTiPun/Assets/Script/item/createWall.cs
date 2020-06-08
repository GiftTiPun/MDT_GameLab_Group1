using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createWall : MonoBehaviour
{
    public GameObject createwall;
    public GameObject wallmodel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            wallmodel.SetActive(true);
        }
    }
    public void Destroy_wall()
    {
        Score score = GameObject.Find("player").GetComponent<Score>();
        //to use find gameobject that contain score of each level and change statement in if to number of enemy in each level
        if (score.score >= 4f)
        {
            Destroy(wallmodel);
            Destroy(createwall);
        }
    }
    private void Update()
    {
        Destroy_wall();
    }
}
