﻿

using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Displaying Player Score? -> " + score);
    }

    // Update is called once per frame
    void Update()
    {
        print(message: "Your score is " + score + "!");
    }
}
