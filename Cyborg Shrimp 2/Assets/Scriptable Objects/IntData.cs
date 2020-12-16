using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int score;
    public int playerHealth;
    public int enemyHealth;

    public void UpdateScore(int number)
    {
        score += number;
        Debug.Log("Score = " + score);
    }

    public void UpdatePlayerHealth(int number)
    {
        if (playerHealth < 100)
        {
            playerHealth += (number);
        }
        
        Debug.Log("Player Health = " + playerHealth);
    }

    public void UpdateEnemyHealth(int number)
    {
        if (enemyHealth < 50)
        {
            enemyHealth += (number);

        }
        
        Debug.Log("Enemy Health = " + enemyHealth);
    }
}
