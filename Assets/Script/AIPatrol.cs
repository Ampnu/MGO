using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPatrol : MonoBehaviour
{
    private Transform player;               // Reference to the player's position.
    private NavMeshAgent enemy;             // Reference to the nav mesh agent.
    private int waypointIndex = 0;

    public GameObject[] waypoints;
    public float patrolSpeed = 0.5f;
    public float chaseSpeed = 1f;
    public float waypointDis;
    public bool atPoint = false;
    public bool isChase = false;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
        waypoints = GameObject.FindGameObjectsWithTag("WayPoint");
    }

    // Update is called once per frame
    void Update()
    {
        PatrolStatus();
        if (!isChase)
        {
           Patrol(atPoint);
        }
        else
        {
            Chase();
        }
    }

    void PatrolStatus()
    {
        if (Vector3.Distance(this.transform.position, waypoints[0].transform.position) <= 0.5)
        {
            atPoint = true;
        }

        if (Vector3.Distance(this.transform.position, waypoints[1].transform.position) <= 0.5)
        {
            atPoint = false;
        }
    }

    void Patrol(bool isThere)
    {
        if (isThere)
        {
            enemy.SetDestination(waypoints[1].transform.position);
        }
        else
        {
            enemy.SetDestination(waypoints[0].transform.position);
        }
    }

    void Chase()
    {
        enemy.SetDestination(player.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isChase = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isChase = false;
        }
    }
}
