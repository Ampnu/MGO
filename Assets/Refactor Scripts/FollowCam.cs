using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//-----Camera to follow player-----//

public class FollowCam : MonoBehaviour
{
    public Transform target;
    private float cameraOffset_x;
    private float cameraOffset_z;
    private Vector3 newCamPosition;

    [Range (1.0f, 2.0f)]
    public float smoothFactor = 1.5f;

	void Start ()
    {
        SetCamOffSet();
    }
    
	void LateUpdate ()
    {
        SetCamTargetPosition();
        MoveCamtoNewPosition();
    }

    //--------------------------------------------------------------------------CORE FUNCTIONS----------------------------------------------------------------------------------------------//

    void SetCamTargetPosition()
    {
        float newPosx = this.target.position.x + cameraOffset_x;
        float newPosz = this.target.position.z + cameraOffset_z;
        newCamPosition = new Vector3(newPosx, 18, newPosz);
    }

    void MoveCamtoNewPosition()
    {
        this.transform.position = Vector3.Slerp(this.transform.position, newCamPosition, smoothFactor);
    }

    //The distance between the camera and the player
    void SetCamOffSet()
    {
        cameraOffset_x = this.transform.position.x - target.position.x;
        cameraOffset_z = this.transform.position.z - target.position.z;
    }
   

    

}
