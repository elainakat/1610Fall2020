using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    
    public float speed;
    public float xInput, zInput, moveX, moveZ;

    public float jumpForce;
    public bool isOnGround = true;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        //Improved Scoot / Roll
        xInput = Input.GetAxis("Horizontal") * speed;
        zInput = Input.GetAxis("Vertical") * speed;
        moveX = xInput + zInput;
        moveZ = -xInput + zInput;
        playerRb.AddForce(moveX, 0, moveZ, ForceMode.Impulse);

        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        //Destroy out of bounds
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            print("Game Over");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
    
    //public void
}
