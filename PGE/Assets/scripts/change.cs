using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("change"))
        {
            gameObject.GetComponent<player_controller>().enabled = false;
            gameObject.GetComponent<player_controller2>().enabled = true;
        }
    }
}
