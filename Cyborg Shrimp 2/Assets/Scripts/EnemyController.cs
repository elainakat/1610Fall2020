using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody enemyRb;
    private GameObject player;
    private float spawnRange = 19.0f;
    
    //AI movement
    private Vector3 target = new Vector3(1, 1, 1);

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        //Find Player
        //Vector3 moveDirection = (player.transform.position - transform.position).normalized;
        //enemyRb.AddForce(moveDirection * speed);
        
        //Teleport Enemy
        InvokeRepeating("TeleportEnemy", 1, 10);

        //Destroy out of bounds
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }

    }
    
    private Vector3 GenerateNewPosition()
    {
        float newPosX = Random.Range(0, spawnRange);
        float newPosZ = Random.Range(0, spawnRange);
        Vector3 randomPos = new Vector3(newPosX, 1, newPosZ);
        return randomPos;
    }

    void TeleportEnemy()
    {
        target = GenerateNewPosition();
        transform.position = Vector3.MoveTowards(transform.position, target, speed);
        
    }
    
}
