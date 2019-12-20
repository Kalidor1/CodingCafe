using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int coinValue = 10;
    public GameObject main;
    
    [Header("VFX")]
    public GameObject explosionParticles;

    private void Start()
    {
        if(main == null)
        {
            main = gameObject;
            print("Take own gameObject for CoinScript");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Inventory"))
        {

            print(collision.gameObject.tag);
            PlayerInventory inv = collision.GetComponent<PlayerInventory>();
            if (inv != null)
            {
                if( inv.addCoin(coinValue) ) {
                    Instantiate(explosionParticles, transform.position, Quaternion.identity);
                    
                    Camera.main.GetComponent<cameraShake>().Shake(0.1f, 3f);

                    Destroy(main);
                }
            }    

        }
    }

}

