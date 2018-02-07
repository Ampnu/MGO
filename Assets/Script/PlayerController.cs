using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0F;
    public float turnSpeed = 100;
    public float jumpSpeed = 8.0F;
    public float gravity = 9.81F;

    

    private Vector3 moveDirection = Vector3.zero;    
    private CharacterController controller;
    private float horz, vert;
    public bool isJump;
  

    void Start()
    {    
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        MovePlayer(horz, vert);
        //isJump = false;

    }

    void MovePlayer(float h, float v)
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(h, 0, v);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            //if (isJump)
            //{
            //    moveDirection.y = jumpSpeed;
            //}
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);               
    }

    //public void Jump(bool jump)
    //{
    //    if (jump)
    //    {
    //        moveDirection.y = jumpSpeed;
    //    }
    //}

}
