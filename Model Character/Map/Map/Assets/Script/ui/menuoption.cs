using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuoption : MonoBehaviour
{
    public GameObject bgmsound;
    public float set = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void All()
    {
        if (set == 0)
        {
            click2();
        }
        else if (set == 2)
        {
            click1();
        }
    }
    void click1()
    {       
        bgmsound.SetActive(true);
        set = 0;
    }
    void click2()
    {
        bgmsound.SetActive(false);
        set = 2;
    }
}
