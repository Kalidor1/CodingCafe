using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleButtonScript : MonoBehaviour
{
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
