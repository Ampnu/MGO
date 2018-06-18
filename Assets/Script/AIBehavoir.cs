using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBehavoir : MonoBehaviour
{
    // Reference to the player's position
    public Transform player; 
    
    //Enemy Nav variables
    public GameObject[] slurbs;
    public Transform station1;
    public Transform station2;

    private bool chase;
  
    // Initialization spawned enemies
    void Start ()
    {
        slurbs = GameObject.FindGameObjectsWithTag("Slurbs");
        slurbs[0].GetComponent<NavMeshAgent>().avoidancePriority = 20;
        slurbs[1].GetComponent<NavMeshAgent>().avoidancePriority = 40;
        slurbs[2].GetComponent<NavMeshAgent>().avoidancePriority = 60;
        slurbs[3].GetComponent<NavMeshAgent>().avoidancePriority = 80;
        slurbs[4].GetComponent<NavMeshAgent>().avoidancePriority = 80;

        slurbs[0].GetComponentInChildren<Renderer>().material.color = Color.green;
        slurbs[1].GetComponentInChildren<Renderer>().material.color = Color.blue;
        slurbs[2].GetComponentInChildren<Renderer>().material.color = Color.red;
        slurbs[3].GetComponentInChildren<Renderer>().material.color = Color.yellow;
        slurbs[4].GetComponentInChildren<Renderer>().material.color = Color.magenta;       
    }

    // Assign each enemy to a behavior (chase, patrol)
    void Update ()
    {
        PatrolTop(slurbs[0]);
        PatrolBottom(slurbs[1]);
        Chase(slurbs[2]);
        Chase(slurbs[3]);
        Chase(slurbs[4]);

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
