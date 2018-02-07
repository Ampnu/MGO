using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCollection : MonoBehaviour {

    private GameManager points;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ++points.score;
            gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        points = GameObject.Find("Game Manager").GetComponent<GameManager>();
        
    }
}
