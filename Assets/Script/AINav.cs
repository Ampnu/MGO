using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class AINav : MonoBehaviour
{
    //public NavMeshAgent enemy;
    //public Transform player;
    //public enum State { PATROL, CHASE };
    //public State state;
    //public GameObject[] waypoints;
    //public float patrolSpeed = 0.5f;
    //public float chaseSpeed = 1f;
    //public GameObject target;

    //private bool alive;
    //private int waypointIndex = 0;

    //// Use this for initialization
    //void Start()
    //{
    //    player = GameObject.FindGameObjectWithTag("Player").transform;
    //    enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
    //    enemy.updatePosition = true;
    //    enemy.updateRotation = false;
    //    state = AINav.State.PATROL;
    //    alive = true;
    //    StartCoroutine("FSM");
    //}

    //IEnumerator FSM()
    //{
    //    while (alive)
    //    {
    //        switch (state)
    //        {
    //            case State.PATROL: Patrol();
    //                break;
    //            case State.CHASE:Chase();
    //                break;
    //        }
    //        yield return null;
    //    }
    //}

    //void Patrol()
    //{
    //    enemy.speed = patrolSpeed;
    //    if (Vector3.Distance(this.transform.position, waypoints[waypointIndex].transform.position)>=2)
    //    {
    //        enemy.SetDestination(waypoints[waypointIndex].transform.position);
    //    }
    //}

    //void Chase()
    //{

    //}

    //void OnTriggerEnter(Collider other)
    //{

    //}
}

