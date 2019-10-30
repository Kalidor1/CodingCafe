using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public Rigidbody2D bullet;
    public float speed;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Rigidbody2D clone = Instantiate(bullet, transform.position, transform.rotation);
            clone.velocity = new Vector2(transform.localScale.x * speed, 0f);
            
         
        }
        
  

    }
}
