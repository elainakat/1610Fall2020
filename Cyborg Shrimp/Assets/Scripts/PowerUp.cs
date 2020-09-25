

using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int score;
    public UnityEvent powerUpEvent;

    private void OnTriggerEnter(Collider other)
    {
        score++;
        print("Player score is: " + score);
        //powerUpEvent.Invoke();

    }
}
