using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiespawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    public Transform spawnPoint;            
    public float spawnIntervalMin = 2f;     
    public float spawnIntervalMax = 5f;     
    private float spawnTimer;              

    void Start()
    {
        spawnTimer = Random.Range(spawnIntervalMin, spawnIntervalMax);
    }

   
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            SpawnZombie();
            spawnTimer = Random.Range(spawnIntervalMin, spawnIntervalMax);
        }
    }
    void SpawnZombie()
    {
        Instantiate(zombiePrefab, spawnPoint.position, Quaternion.identity);
    }
}
