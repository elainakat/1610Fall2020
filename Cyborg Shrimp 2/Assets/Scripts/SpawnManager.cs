using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject coinPrefab;
    public float repeatRate = 5;
    void Start()
    {
        InvokeRepeating("SpawnCoin", 1, repeatRate);
    }

    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnRange = 19.0f;
        
        float spawnPosX = Random.Range(0, spawnRange);
        float spawnPosZ = Random.Range(0, spawnRange);
        Vector3 spawnPos = new Vector3(spawnPosX, 1, spawnPosZ);
        return spawnPos;
    }

    void SpawnCoin()
    {
        Vector3 spawnPos = GenerateSpawnPosition();
        Instantiate(coinPrefab, spawnPos, coinPrefab.transform.rotation);
    }
}
