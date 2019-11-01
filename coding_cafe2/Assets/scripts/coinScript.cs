using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    // Start is called before the first frame update
    int coinValue = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
   
        if (collision.gameObject.CompareTag("ItemColl"))
        {
            scoreManager.instance.ScoreFunction(coinValue);
            Destroy(gameObject);


        }
    }
}
