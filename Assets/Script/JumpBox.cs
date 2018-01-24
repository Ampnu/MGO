using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBox : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            print("Player Jump");
        }
    }
}
