using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBox : MonoBehaviour {

    public bool jump = false;
    public Transform player;
    public Animator anim;
    public float jumpSpeed = 100f;
    //public float gravity = 9.81F;

    //private Vector3 jumpDirection;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            print("JUMP");
            player.transform.TransformDirection(0,jumpSpeed,0);
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
        player = GetComponent<Transform>();
        
    }

    void Update()
    {
        
    }
}