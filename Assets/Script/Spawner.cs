using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    public GameObject slurbPrefab;
    public GameObject relicPrefab;
    public int numberEnemies;

    private GameObject[] spawnPos;

    // Use this for initialization
    void Awake ()
    {
        spawnPos = GameObject.FindGameObjectsWithTag("Respawn");                //Find all spawn points in the maze
        System.Random randomNumber = new System.Random(GetInstanceID());        //Create unquie random numbers

        SpawnEnemies();
        SpawnRelic();
    }

    void SpawnEnemies()
    {
        for(int i = 0; i < numberEnemies; ++i)
        {
            int index = Random.Range(0, spawnPos.Length); //Choose random number from 0 to 17
            Instantiate(slurbPrefab, spawnPos[index].transform.position, spawnPos[index].transform.rotation); //Instantiate slurb in maze at a random spawn point
            
        }  
    }

    void SpawnRelic()
    {
        int index = Random.Range(0, spawnPos.Length); //Choose random number from 0 to 17
        Instantiate(relicPrefab, spawnPos[index].transform.position, spawnPos[index].transform.rotation); //Instantiate relic in maze at a random spawn point
    }
}
