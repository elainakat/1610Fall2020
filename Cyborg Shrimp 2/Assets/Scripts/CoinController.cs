using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinController : MonoBehaviour
{
    public float changeRate = 1;
    public int teleportRange = 1;

    private Vector3 target = new Vector3(1, 1, 1);

    void Start()
    {
        InvokeRepeating("TeleportCoin", 1, changeRate);
    }

    void Update()
    {
        //Destroy out of bounds
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }

        transform.Rotate(0, 0, 1);

    }

    private Vector3 GenerateNewPosition()
    {
        int newPosX = Random.Range(0, 18);
        int newPosZ = Random.Range(0, 18);
        Vector3 newPos = new Vector3(newPosX, 1, newPosZ);

        //Vector3 newPos = randomPos + transform.position;

        return newPos;
    }

    void TeleportCoin()
    {
        target = GenerateNewPosition();

        transform.position = Vector3.MoveTowards(transform.position, target, teleportRange);
        //print("Target = " + target);
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
