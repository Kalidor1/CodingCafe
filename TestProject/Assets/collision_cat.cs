using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class collision_cat : MonoBehaviour
{
   
    public BoxCollider2D catBox;

    // Start is called before the first frame update
    void Start()
    {
    
       
    }

    // Update is called once per frame
    void Update()
    {
        GameObject dog = GameObject.Find("dog");
        BoxCollider2D dog2 = dog.GetComponent<BoxCollider2D>();
        Rigidbody2D dog3 = dog.GetComponent<Rigidbody2D>();

        if (catBox.IsTouching(dog2))
        {
            Debug.Log("HIT");
        }
    }
}
