using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//--This script rotates player mesh alongs it's local axis--//

public class RotatePlayer1 : MonoBehaviour
{
    public float turnSpeed = 100;
    public PlayerController player;

    private Quaternion targetRotation;
	
	// Update is called once per frame
	void Update ()
    {
        TurnPlayer(player.horz, player.vert);
	}

    void TurnPlayer(float h, float v)
    {
        if (h == 0 && v > 0) //Moving UP
        {
            Quaternion targetDir = Quaternion.Euler(0, -90, -90);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h == 0 && v < 0) //Moving DOWN
        {
            Quaternion targetDir = Quaternion.Euler(0, 90, -90);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);

        }

        if (h > 0 && v > 0) //Moving RIGHT-UP
        {
            Quaternion targetDir = Quaternion.Euler(0, -45, -90);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h < 0 && v < 0) //Moving LEFT-DOWN
        {
            Quaternion targetDir = Quaternion.Euler(0, 135, -90);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h > 0 && v == 0) //Moving RIGHT
        {
            Quaternion targetDir = Quaternion.Euler(0, 0, -90);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h < 0 && v == 0) // Moving LEFT
        {
            Quaternion targetDir = Quaternion.Euler(0, 180, -90);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h > 0 && v < 0) //Moving RIGHT-DOWN
        {
            Quaternion targetDir = Quaternion.Euler(0, 45, -90);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

        if (h < 0 && v > 0) //Moving LEFT-UP
        {
            Quaternion targetDir = Quaternion.Euler(0, 225, -90);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, targetDir, turnSpeed);
        }

    }
}
