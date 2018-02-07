using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBox : MonoBehaviour {


    //if player in enter jumpbox then make player jump (move transform up times jump speed) and start jump animation
    //when player is inAir then start applying gravity
    //when player exit jumpbox end jump animation

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            print("JUMP");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            print("LAND");
        }
    }

    void Start()
    {

        
       
    }

    void Update()
    {
        

    }
}