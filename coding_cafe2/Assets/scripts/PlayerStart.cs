using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindGameObjectWithTag("Player").transform.position = transform.position;
    }

    // Update is called once per frame

}
