using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCreater : MonoBehaviour
{
    public GameObject gem1;
    public GameObject gem2;
    public GameObject gem3;
    public GameObject gem4;
    
    public void AppearGem()
    {
        Score score = GameObject.Find("player").GetComponent<Score>();
 
        if (score.score == 5 )
        {
            gem1.SetActive(true);
            score.score++;
        }
        if (score.score == 11)
        {
            gem2.SetActive(true);
            score.score++;
        }
        if (score.score == 15)
        {
            gem3.SetActive(true);
            score.score++;
        }
        if (score.score == 19)
        {
            gem4.SetActive(true);
            score.score++;
        }
    }

    public void Update()
    {
        AppearGem();
    }
}
