using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour

{
    public TextMeshProUGUI cointext;
    public TextMeshProUGUI moneytext;
    public static scoreManager instance;
    public int maxCollectedCoins;
    [Header("CURRENT INVENTORY")]
    public int score;
    public int collectedCoins;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool ScoreFunction(int value)
    {
        if (collectedCoins +1 <= maxCollectedCoins)
        {
            collectedCoins++;
            score += value;
            cointext.text = "Coins: " + collectedCoins.ToString();
            moneytext.text = "Money: " + score.ToString();
            return true;
            //once you return you are out of the function
        }
        return false;
    }
}
