

using System;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int score;
    public UnityEvent powerUpEvent;
    public float gravity = -9.81f;
    private Vector3 moveDirection;
    private float yDirection;


    private void Update()
    {
        //Gravity
        yDirection += gravity * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        print("Player score is: " + score);
        //powerUpEvent.Invoke();

    }
}
