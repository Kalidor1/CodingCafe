using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int maxCollectedCoins;
    [Header("CURRENT INVENTORY")]
    public int score;
    public int collectedCoins;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool ScoreFunction(int value)
    {
        if (collectedCoins + 1 <= maxCollectedCoins)
        {
            collectedCoins++;
            score += value;
            return true;
            //once you return you are out of the function
        }
        return false;
    }
}
