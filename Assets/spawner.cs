using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemyPrefab; 
    public float spawnInterval = 2f; 
    public float spawnXMin = -5f, spawnXMax = 5f; 
    public float spawnY = 0f; 

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnEnemy();
        }
    }
    private void SpawnEnemy()
    {
        float spawnX = Random.Range(spawnXMin, spawnXMax);
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, transform.position.z);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
    void Update()
    {
        
    }
}
