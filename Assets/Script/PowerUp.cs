using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public ParticleSystem powerUp;

    // Use this for initialization
    void Start ()
    {
        powerUp.Stop(true);
	}
}
