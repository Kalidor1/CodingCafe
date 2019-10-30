using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public Rigidbody2D bullet;
    public float speed;
    private float shootTime = 0;
    public float attackSpeed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootTime = shootTime - Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftShift)&& shootTime <= 0f)
        {
            Rigidbody2D clone = Instantiate(bullet, transform.position, transform.rotation);
            clone.velocity = new Vector2(transform.localScale.x * speed, 0f);
            shootTime = attackSpeed;

        }


            



    }
}
