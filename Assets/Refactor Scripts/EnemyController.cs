using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public State enemyState;
    public enum State { PATROL, CHASE, RUN, FREEZE};
    private Animation animSpeed;
    private string role;

    //Variables for Patroling
    public GameObject[] waypoint; //**Normalize animation speed**//
    public int waypointIndex = 0;
    public float patrolSpeed = 1.0f;

    //Variables for Chasing
    private Transform target; //**Increase animation speed**//
    public float chaseSpeed = 2.0f;

    //Variables for Running Away
    public float runSpeed = 3.0f; //**Increase animation speed**//

    //Variables for Freeze


    private NavMeshAgent enemy;

    // Use this for initialization
    void Start ()
    {
        waypoint = GameObject.FindGameObjectsWithTag("Waypoint");
        enemy = this.GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        role = this.GetComponent<Troll_ID>().ID;

        if (role == "Patrol")
        {
            enemyState = EnemyController.State.PATROL;
        }

        if (role == "Chase")
        {
            enemyState = EnemyController.State.CHASE;
        }
    }

    void Update()
    {
        if (role == "Chase")
        {
            FiniteStateMachine_1(enemyState);
        }

        if (role == "Patrol")
        {
            FiniteStateMachine_2(enemyState);
        }     
    }
	
    void FiniteStateMachine_1(State val)
    {
        switch (val)
        {
            case State.CHASE:
                Chase();
                break;
        }
    }

    void FiniteStateMachine_2(State val)
    {
        switch (val)
        {
            case State.PATROL:
                Patrol();
                break;

            case State.CHASE:
                Chase();
                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            enemyState = EnemyController.State.CHASE;
        }       
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enemyState = EnemyController.State.PATROL;
        }
    }

    void Patrol()
    {
        enemy.speed = patrolSpeed;

        if (Vector3.Distance(this.transform.position, waypoint[waypointIndex].transform.position) >= 1f)
        {
            enemy.SetDestination(waypoint[waypointIndex].transform.position);
        }
        else
        {
            waypointIndex++;

            if (waypointIndex == waypoint.Length)
            {
                waypointIndex = 0;
            }   
        }
    }

    void Chase()
    {
        enemy.speed = chaseSpeed;
        enemy.SetDestination(target.transform.position);
    }
}
