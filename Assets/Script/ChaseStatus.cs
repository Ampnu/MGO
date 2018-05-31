using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChaseStatus : MonoBehaviour {

    public bool isChase;
    private ItemCollection playerStatus;
    

    private int freezeTime = 10;

    private void Start()
    {
        playerStatus = GameObject.Find("Relic(Clone)").GetComponent<ItemCollection>();

        isChase = true;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player" && playerStatus.powerStatus == true)
        {
            print("FREEZE SLURB");
        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player" && playerStatus.powerStatus == true)
    //    {
    //        print("FREEZE SLURB");
    //    }
    //}

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        isChase = false;
    //    }
    //}

    IEnumerator Mummified()
    {
        //stop movement
        //change color to white
        //this.GetComponentInChildren<Renderer>().material.color = Color.white;
        this.GetComponent<NavMeshAgent>().speed = 0;
        yield return new WaitForSeconds(freezeTime);
        this.GetComponent<NavMeshAgent>().speed = 2;

    }
}
