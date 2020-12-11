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

    }

    private Vector3 GenerateNewPosition()
    {
        float newPosX = Random.Range(-teleportRange, teleportRange);
        float newPosZ = Random.Range(-teleportRange, teleportRange);
        Vector3 randomPos = new Vector3(newPosX, 0, newPosZ);

        Vector3 newPos = randomPos + transform.position;

        
        //Incomplete out of bounds teleporting prevention
        /*if (newPos.x < 18.0f && newPos.x > 0 && newPos.y < 18.0f && newPos.y > 0)
        {
            return newPos;
        }*/

        return newPos;
    }

    void TeleportCoin()
    {
        target = GenerateNewPosition();

        if (target.x < 18.0f && target.x > 0 && target.y < 18.0f && target.y > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, teleportRange);
        }
        else
        {
            target = GenerateNewPosition();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
