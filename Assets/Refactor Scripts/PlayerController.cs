using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//-----This script takes player input and moves character accordingly-----//

public class PlayerController : MonoBehaviour
{    
    private CharacterController controller;

    public float speed = 5.0F;
    private float gravity = 9.81F;
    private Vector3 moveDirection = Vector3.zero;    
    private float horz, vert;

    void Start()
    {    
        controller = this.GetComponent<CharacterController>();
    }

    void Update()
    {
        TakePlayerInput();
        MovePlayer(horz, vert);
    }

    //--------------------------------------------------------------------------CORE FUNCTIONS----------------------------------------------------------------------------------------------//

    void TakePlayerInput()
    {
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
    }
 
    void MovePlayer(float horz, float vert)
    {
        if (controller.isGrounded)
        {
            SetPlayerDirection(horz,vert);
        }
        controller.Move(moveDirection * Time.deltaTime);

        moveDirection.y -= gravity * Time.deltaTime;
    }

    void SetPlayerDirection(float h, float v)
    {
        moveDirection = new Vector3(h, 0, v);
        WorldtoLocalSpace(moveDirection);
        moveDirection *= speed; 
    }

    void WorldtoLocalSpace(Vector3 val)
    {
        moveDirection = transform.TransformDirection(val);
    }    
}
