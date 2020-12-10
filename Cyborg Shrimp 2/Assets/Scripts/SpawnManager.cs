using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 18.0f;
    private Vector3 spawnPos = new Vector3(0,0,0);
    public float repeatRate = 5;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, repeatRate);
    }

    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(0, spawnRange);
        float spawnPosZ = Random.Range(0, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 1, spawnPosZ);
        return randomPos;
    }

    void SpawnEnemy()
    {
        spawnPos = GenerateSpawnPosition();
        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
    }
}
