

using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    
    public CharacterController controller;
    public float moveSpeed = 5f, gravity = -9.81f, jumpForce = 10f;
    
    
    private Vector3 moveDirection;
    private float yDirection;

    private void Update()
    {
        //Speed
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        //Direction
        moveDirection.Set(moveSpeedInput, yDirection, 0);

        //Gravity
        yDirection += gravity * Time.deltaTime;
        
        if (controller.isGrounded && moveDirection.y < 0)
        {
            yDirection = -1f;
        }

        //Jump
        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }
        
        //Movement
        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);
        
    }

}
