using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform target;
    private Rigidbody camMotion;
    private float cameraOffset_x;
    private float cameraOffset_z;
    public float dragFactor = 0;
    private Vector3 currentPos;
    private Vector3 newCamPosition;
    private Vector3 lastPosition;
    private float direction;

    [Range (1.0f, 2.0f)]
    public float smoothFactor = 1.5f;

	// Use this for initialization
	void Start ()
    {
        //The distance between the camera and the player
        cameraOffset_x = this.transform.position.x - target.position.x; 
        cameraOffset_z = this.transform.position.z - target.position.z;
    }
    
	void LateUpdate ()
    {
        //Set postion of the camera relative to the player
        newCamPosition = new Vector3(this.target.position.x + cameraOffset_x, 18, this.target.position.z+cameraOffset_z);
        
        //Calculate direction
        currentPos.z = this.transform.position.z;
        direction = newCamPosition.z - currentPos.z;
        print(direction);

        if (direction > 0) //positive
        {
            newCamPosition = new Vector3(this.target.position.x + cameraOffset_x, 18, (this.target.position.z + cameraOffset_z) + dragFactor);
        }

        if (direction == 0)
        {
            newCamPosition = new Vector3(this.target.position.x + cameraOffset_x, 18, this.target.position.z + cameraOffset_z);
        }

        if (direction > 0)
        {
            newCamPosition = new Vector3(this.target.position.x + cameraOffset_x, 18, (this.target.position.z + cameraOffset_z) - dragFactor);
        }

        //Moves the camera to new position of the player
        this.transform.position = Vector3.Slerp(this.transform.position, newCamPosition, smoothFactor);

        //dragFactor = dragFactor + 0.0722f;



    }

    

}
