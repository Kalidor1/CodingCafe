using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    [Header("MAX VALUES")]
    public int maxCollectedCoins = 2;

    [Header("CURRENT INVENTORY")]
    public int collectedMoney;
    public int collectedCoins;

    [Header("UI ELEMENTS")]
    public Text coinText;
    public Text moneyText;

    private void Start()
    {
        coinText.text = "Remaining Coins: " + (maxCollectedCoins - collectedCoins);
        moneyText.text = "Money: " + collectedMoney;
    }

    public bool addCoin(int value)
    {
        if (collectedCoins + 1 <= maxCollectedCoins)
        {
            collectedCoins++;
            collectedMoney = collectedMoney + value; //collectedMoney += value;
            coinText.text = "Remaining Coins: " + (maxCollectedCoins - collectedCoins);
            moneyText.text = "Money: " + collectedMoney;
            return true;
        }
        return false;
    }
}
