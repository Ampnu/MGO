using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    public List<GameObject> enemy;
    public List<GameObject> spawnPoints;
    public GameObject effect;

    // Use this for initialization
    void Awake()
    {
        SpawnEnemies();
    }

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < enemy.Count; ++i)
        {
            yield return new WaitForSeconds(3);
            int index = Random.Range(0, spawnPoints.Count); //Choose random number from 0 to 17
            Instantiate(effect, spawnPoints[index].transform.position, spawnPoints[index].transform.rotation); //Instantiate enemy in maze at a random spawn point
            enemy[i].transform.position = spawnPoints[index].transform.position;
            enemy[i].SetActive(true);
            spawnPoints.Remove(spawnPoints[index]);
            //yield return new WaitForSeconds(3);
        }
    }
}
