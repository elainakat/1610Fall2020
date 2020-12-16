using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    public bool gameOver;
    public bool playerDead;
    public bool enemyDead;
    public bool powerShieldActive;

    public void UpdateGameOver(bool value)
    {
        
    }
}
