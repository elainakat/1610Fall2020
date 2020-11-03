using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject baddiePrefab;
    private Vector3 spawnPos = new Vector3(0,0,0);
    private float repeatRate = 1;
    
    void Start()
    {
        InvokeRepeating("SpawnBaddie", 0, repeatRate);
    }

    void Update()
    {
        
    }

    void SpawnBaddie()
    {
        spawnPos = new Vector3(750, 30, 250);
        Instantiate(baddiePrefab, spawnPos, baddiePrefab.transform.rotation);
    }
}
