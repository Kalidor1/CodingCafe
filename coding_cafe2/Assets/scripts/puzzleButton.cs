using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleButton : MonoBehaviour
{
    // Start is called before the first frame update


    public bool active = true;
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && active)
        {
            active = false;
            Destroy(door);
        }
    }

}
