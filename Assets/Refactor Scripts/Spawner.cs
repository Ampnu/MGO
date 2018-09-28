using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawner : MonoBehaviour
{
    public List<GameObject> enemy;
    public List<GameObject> spawnPoints;
    public List<GameObject> relic;

    void Start()
    {
        SpawnRelic();
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < enemy.Count; ++i)
        {
            yield return new WaitForSeconds(3);
            int index = Random.Range(0, spawnPoints.Count); //Choose spawn number from 0 to 17
            enemy[i].GetComponentInChildren<ParticleSystem>().Play();
            enemy[i].transform.position = spawnPoints[index].transform.position;
            enemy[i].SetActive(true);
            spawnPoints.Remove(spawnPoints[index]);
        }
    }

    void SpawnRelic()
    {
        int index = Random.Range(0, spawnPoints.Count); //Choose spawn number from 0 to 17
        Instantiate(relic[0], spawnPoints[index].transform.position, spawnPoints[index].transform.rotation);
        spawnPoints.Remove(spawnPoints[index]);
    }
}
