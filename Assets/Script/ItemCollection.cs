﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollection : MonoBehaviour {

    private GameManager points;
    private PlayerController playerPickUp;

    void OnTriggerEnter(Collider other)
    {
        //When a player hits a orb
        if (other.tag == "Player")
        {
            playerPickUp.ping.Play();
            ++points.score;
            this.gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        points = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerPickUp = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();      
    }
}
