using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private CharacterController controller;
    public AudioSource ping;

    public float speed = 5.0F;
    public float arcSpeed = 4.0F;
    private float gravity = 9.81F;
    private Vector3 moveDirection = Vector3.zero;    
    private float horz, vert;

    void Start()
    {    
        controller = this.GetComponent<CharacterController>();
        ping = GetComponent<AudioSource>();
    }

    void Update()
    {
        //--Player Input--//
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        //print("Horz: " + horz + " Vert: " + vert);

        //--Player Movement--//
        MovePlayer(horz, vert);
    }

    //--This functions takes player input and moves the character through the scene--//
    void MovePlayer(float h, float v)
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(h, 0, v);
            moveDirection = transform.TransformDirection(moveDirection); //transforming from world to local space
            moveDirection *= speed; //adding speed factor

            //if (h == Mathf.Abs(1f) && v == Mathf.Abs(1f))
            //{
            //    moveDirection *= arcSpeed; //adding speed factor
            //}
            //else
            //{
            //    moveDirection *= speed; //adding speed factor
            //}
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);               
    }
}
