using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    public List<GameObject> slurbs;
    public List<GameObject> spawnPoint;
    private GameObject[] spawn;
    public GameObject prefab;

	// Use this for initialization
	void Start ()
    {
        System.Random randomNumber = new System.Random(GetInstanceID());
        LoadSpawnPoints();
        SpawnEnemies();
    }
    
    void LoadSpawnPoints()
    {
        spawn = GameObject.FindGameObjectsWithTag("Respawn");

        for (int i = 0; i < spawn.Length; ++i)
        {
            spawnPoint.Add(spawn[i]);
        }
    }

    void SpawnEnemies()
    {
        for(int i = 0; i < 4; ++i)
        {
            int index = Random.Range(0, 16);
            int enemySpeed = Random.Range(2, 5);
            Instantiate(prefab, spawnPoint[index].transform.position, Quaternion.identity);
            print(enemySpeed);
        }  
    }
}
