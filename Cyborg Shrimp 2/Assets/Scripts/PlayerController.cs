using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    
    public float speed;
    public float moveX, moveZ;

    public float jumpForce;
    public bool isOnGround;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Scoot
        //moveX = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        //moveZ = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        //transform.Translate(moveX, 0, moveZ);
        
        //Improved Scoot / Roll
        moveX = Input.GetAxis("Horizontal") * speed;
        moveZ = Input.GetAxis("Vertical") * speed;
        playerRb.AddForce(moveX, 0, moveZ, ForceMode.Force);
        
        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
        else
        {
            isOnGround = true;
        }
        
        //Destroy out of bounds
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            Debug.Log(message: "Game Over");
        }
    }
}
