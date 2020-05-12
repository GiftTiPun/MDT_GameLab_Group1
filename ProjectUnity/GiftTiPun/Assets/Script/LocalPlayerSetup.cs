using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalPlayerSetup : MonoBehaviour
{
    public GameObject isLocalPlayer;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("EnemyManager").SetActiveRecursively(true);

        if (isLocalPlayer)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<camerarotation1>().enabled = true;
            GetComponent<WalkingPlayer1>().enabled = true;
            GetComponentInChildren<PlayerAttack>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
