

using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Displaying Player Score? -> " + health);
    }

    // Update is called once per frame
    void Update()
    {
        print(message: "Your health is " + health + ".");
    }
}
