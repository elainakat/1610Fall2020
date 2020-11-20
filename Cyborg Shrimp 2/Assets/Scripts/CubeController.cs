using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Rigidbody cubeRb;
    
    public float speed;
    public float moveX, moveZ;

    public float jumpForce;
    public bool isOnGround;
    
    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Scoot
        moveX = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        moveZ = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(moveX, 0, moveZ);
        
        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            cubeRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
        else
        {
            isOnGround = true;
        }
    }
}
