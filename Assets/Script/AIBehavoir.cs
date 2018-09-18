using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBehavoir : MonoBehaviour
{
    // Reference to the player's position
    public Transform player; 
    
    //Enemy Nav variables
    public GameObject[] enemy;
    public Transform station1;
    public Transform station2;

    private bool chase;
  
    // Initialization spawned enemies
    void Start ()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        enemy[0].GetComponent<NavMeshAgent>().avoidancePriority = 20;
        enemy[1].GetComponent<NavMeshAgent>().avoidancePriority = 40;
        enemy[2].GetComponent<NavMeshAgent>().avoidancePriority = 60;
        enemy[3].GetComponent<NavMeshAgent>().avoidancePriority = 80;
        enemy[4].GetComponent<NavMeshAgent>().avoidancePriority = 80;

        enemy[0].GetComponentInChildren<Renderer>().material.color = Color.green;
        enemy[1].GetComponentInChildren<Renderer>().material.color = Color.blue;
        enemy[2].GetComponentInChildren<Renderer>().material.color = Color.red;
        enemy[3].GetComponentInChildren<Renderer>().material.color = Color.yellow;
        enemy[4].GetComponentInChildren<Renderer>().material.color = Color.magenta;       
    }

    // Assign each enemy to a behavior (chase, patrol)
    void Update ()
    {
        PatrolTop(enemy[0]);
        PatrolBottom(enemy[1]);
        Chase(enemy[2]);
        Chase(enemy[3]);
        Chase(enemy[4]);

    }

    void PatrolTop(GameObject var)
    {
        if (var.GetComponent<ChaseStatus>().isChase)
        {
            var.GetComponent<NavMeshAgent>().SetDestination(player.position);
        }
        else
        {
            var.GetComponent<NavMeshAgent>().SetDestination(station1.position);
        }
    }

    void PatrolBottom(GameObject var)
    {
        if (var.GetComponent<ChaseStatus>().isChase)
        {
            var.GetComponent<NavMeshAgent>().SetDestination(player.position);
        }
        else
        {
            var.GetComponent<NavMeshAgent>().SetDestination(station2.position);
        }
    } 

    void Chase(GameObject var)
    {
        var.GetComponent<NavMeshAgent>().SetDestination(player.position);
    }
    
}
