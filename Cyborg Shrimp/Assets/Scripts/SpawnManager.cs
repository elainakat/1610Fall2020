using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject baddiePrefab;
    private Vector3 spawnPos = new Vector3(0,0,0);
    
    void Start()
    {
        InvokeRepeating("SpawnBaddie", 0, 0);
    }

    void Update()
    {
        
    }

    void SpawnBaddie()
    {
        Instantiate(baddiePrefab, spawnPos, baddiePrefab.transform.rotation);
    }
}
