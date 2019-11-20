using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    // Start is called before the first frame update
    int coinValue = 1;
    public GameObject main;
    //define main gameobject to destroy everything (all under main)
    private void Start()
    {
        if(main == null)
        {
            main = gameObject;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
   
        if (collision.gameObject.CompareTag("ItemColl"))
        {
            PlayerInventory inv = collision.GetComponent<PlayerInventory>();
            
            if(inv != null)
            {
                if (inv.ScoreFunction(coinValue))
                {
                    Destroy(main);
                }
            }
            scoreManager.instance.ScoreFunction(coinValue);
          



        }
    }
}
