using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseStatus : MonoBehaviour {

    public bool isChase;
   
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isChase = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isChase = false;
        }
    }
}
