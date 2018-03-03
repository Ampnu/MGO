using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    private GameObject[] spawnPos;

    //public GameObject[] slurbs;
    public GameObject slurbPrefab;
    public int numberEnemies;

	// Use this for initialization
	void Awake ()
    {
        spawnPos = GameObject.FindGameObjectsWithTag("Respawn");
        //slurbs = new GameObject[numberEnemies];
        System.Random randomNumber = new System.Random(GetInstanceID());

        SpawnEnemies();
        //slurbs = GameObject.FindGameObjectsWithTag("Slurbs");
    }

    void SpawnEnemies()
    {
        for(int i = 0; i < numberEnemies; ++i)
        {
            int index = Random.Range(0, spawnPos.Length); //Create random number
            Instantiate(slurbPrefab, spawnPos[index].transform.position, spawnPos[index].transform.rotation); //Instantiate slurb in maze at a random spawn point
        }  
    }
}
