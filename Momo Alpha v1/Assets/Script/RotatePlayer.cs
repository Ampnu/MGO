using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--This script rotates player mesh alongs it's local axis--//

public class RotatePlayer : MonoBehaviour
{
    public float turnSpeed;

    private float horz, vert;
    private float runDir;
    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update ()
    {
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        runDir = Mathf.Abs(horz) + Mathf.Abs(vert);
        anim.SetFloat("Speed", runDir);

        if (Input.GetButton("Jump"))
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
     
        TurnPlayer(horz, vert);
    }

    void TurnPlayer(float h, float v)
    {

        if (h == 0 && v > 0) //Moving UP
        {
            Quaternion targetDir = Quaternion.Euler(0, 0, 0);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h == 0 && v < 0) //Moving DOWN
        {
            Quaternion targetDir = Quaternion.Euler(0, 180, 0);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);

        }

        if (h > 0 && v > 0) //Moving RIGHT-UP
        {
            Quaternion targetDir = Quaternion.Euler(0, 45, 0);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h < 0 && v < 0) //Moving LEFT-DOWN
        {
            Quaternion targetDir = Quaternion.Euler(0, 225, 0);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h > 0 && v == 0) //Moving RIGHT
        {
            Quaternion targetDir = Quaternion.Euler(0, 90, 0);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h < 0 && v == 0) // Moving LEFT
        {
            Quaternion targetDir = Quaternion.Euler(0, 270, 0);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h > 0 && v < 0) //Moving RIGHT-DOWN
        {
            Quaternion targetDir = Quaternion.Euler(0, 135, 0);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h < 0 && v > 0) //Moving LEFT-UP
        {
            Quaternion targetDir = Quaternion.Euler(0, 315, 0);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }
    }
}
