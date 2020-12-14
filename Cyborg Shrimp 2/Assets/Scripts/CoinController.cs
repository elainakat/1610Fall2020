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
        int newPosX = Random.Range(-teleportRange, teleportRange);
        int newPosZ = Random.Range(-teleportRange, teleportRange);
        Vector3 randomPos = new Vector3(newPosX, 0, newPosZ);

        Vector3 newPos = randomPos + transform.position;

        return newPos;
    }

    /*void TeleportCoin()
    {
        target = GenerateNewPosition();

        if (target.x < 18.0f && target.x > 0 && target.y < 18.0f && target.y > 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, teleportRange);
            print("Target = " + target);
        }
        else
        {
            Vector3 saveTarget = new Vector3(9, 1, 9);
            transform.position = Vector3.MoveTowards(transform.position, saveTarget, 20);
            print("Out of bounds target = " + target);
        }
    }*/

    void TeleportCoin()
    {
        target = GenerateNewPosition();

        if (target.x > 18.0f || target.x < 0 || target.y > 18.0f || target.y < 0) return;

        transform.position = Vector3.MoveTowards(transform.position, target, teleportRange);
        print("Target = " + target);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
