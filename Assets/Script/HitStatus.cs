//------------------------------------ATTACH THIS SCRIPT TO A CHILD OBJECT WITH A TRIGGER COLLIDER ON ENEMEY-----------------------//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitStatus : MonoBehaviour {

    public bool hit;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            hit = true;
        }
        else
        {
            hit = false;
        }
    }
}
