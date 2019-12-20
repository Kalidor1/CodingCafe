using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbegin : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer> ().enabled = false;
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = transform.position;

        player.GetComponent<PlayerMovement>().SetPosition(transform.position);
    }
}
