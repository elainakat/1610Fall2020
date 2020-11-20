using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baddie : MonoBehaviour
{
    public float speed;
    private Rigidbody baddieRb;
    private GameObject cube;
    
    void Start()
    {
        baddieRb = GetComponent<Rigidbody>();
        cube = GameObject.Find("Cube");
    }

    void Update()
    {
        Vector3 lookDirection = (cube.transform.position - transform.position).normalized;
        baddieRb.AddForce(lookDirection * speed);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
