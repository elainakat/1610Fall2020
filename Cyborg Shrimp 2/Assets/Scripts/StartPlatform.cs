using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(waiter());
    }

    private void OnCollisionExit(Collision other)
    {
        Destroy(gameObject);
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
