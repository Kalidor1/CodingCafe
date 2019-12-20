using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_manager : MonoBehaviour
{
    public float speed;
    public void Spawn(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
