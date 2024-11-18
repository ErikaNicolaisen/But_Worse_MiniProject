using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject pipesPrefab;
    public GameObject roadPrefab;
    public GameObject enemyPrefab;

    [Header("Spawn Rates")]
    [SerializeField] float pipeSpawnRate = 5f;
    [SerializeField] float roadSpawnRate = 5f;
    [SerializeField] float enemySpawnRate = 3f;

    [Header("Spawn Distances")]
    [SerializeField] float pipeSpawnDistance = 20f;
    [SerializeField] float roadSpawnDistance = 20f;
    [SerializeField] float enemySpawnDistance = 20f;

    [Header("Enemy Spawn Range")]
    [SerializeField] float leftSpawnX = -5f;
    [SerializeField] float rightSpawnX = 5f;

    private float pipeTimer = 0f;
    private float roadTimer = 0f;
    private float enemyTimer = 0f;

    void Update()
    {
        if (!PlayerHealth.isPlayerAlive)
            return;

        pipeTimer += Time.deltaTime;
        roadTimer += Time.deltaTime;
        enemyTimer += Time.deltaTime;

        if (pipeTimer >= pipeSpawnRate)
        {
            SpawnPipes();
            pipeTimer = 0f;
        }

        if (roadTimer >= roadSpawnRate)
        {
            SpawnRoad();
            roadTimer = 0f;
        }

        if (enemyTimer >= enemySpawnRate)
        {
            SpawnEnemy();
            enemyTimer = 0f;
        }
    }

    void SpawnPipes()
    {
        float randomY = Random.Range(0f, 5f);
        Vector3 spawnPosition = new Vector3(0, randomY, pipeSpawnDistance);

        Instantiate(pipesPrefab, spawnPosition, Quaternion.identity);
    }

    void SpawnRoad()
    {
    float yposition = 0;
    Vector3 spawnPosition = new Vector3(0, yposition, roadSpawnDistance);

    Instantiate(roadPrefab, spawnPosition, Quaternion.identity);
    }

    void SpawnEnemy()
    {
        float randomX = Random.value < 0.5 ? leftSpawnX : rightSpawnX;
        float randomY = Random.Range(2f, 4f);

        Vector3 spawnPosition = new Vector3(randomX, randomY, enemySpawnDistance);

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
