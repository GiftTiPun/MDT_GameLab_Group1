using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject another1;
    public GameObject another2;
    public GameObject slimesound;
    public GameObject monsound;
    public float set = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void All()
    {
        if(set == 0)
        {
            click2();
        }
        else if(set == 2)
        {
            click1();
        }
    }
    void click1()
    {
        another1.SetActive(false);
        another2.SetActive(false);
        slimesound.SetActive(true);
        monsound.SetActive(true);
        set = 0;
    }
    void click2()
    {
        another1.SetActive(true);
        another2.SetActive(true);
        slimesound.SetActive(false);
        monsound.SetActive(false);
        set = 2;
    }
}
