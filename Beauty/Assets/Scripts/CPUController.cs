using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUController : MonoBehaviour
{
    public Transform laptop;
    public Rigidbody2D rigidBody;
    public float movementSpeed = 0.1f;


    public float healthDecreaseSpeed = 5f;


    public SpriteRenderer spriteRend;
    public Color laptopColor;
    public Color lowHealthColor;
    public Color criticalHealthColor;

    [Range(0,100)]
    public float health;
    
    // Start is called before the first frame update
    void Start()
    {
        // WHEN SCENE LOADS <=
        int i = 0;
        float f = 0.4f;
        bool b = true;
        string name = "Mat";

        
        Debug.Log(name);
        print(name + name);



    }

    // Update is called once per frame
    void Update()
    {
        // EVERY FRAME ONCE (1)
        if (Input.GetKey(KeyCode.Q))
        {
            health = health - healthDecreaseSpeed * Time.deltaTime;
            //DECREASE HEALTH
        } else if (Input.GetKey(KeyCode.E))
        {
            health = health + healthDecreaseSpeed * Time.deltaTime;
        }
        

       if (health < 25)
       {
            spriteRend.color = criticalHealthColor;
        }else if(health < 50)
        {
            spriteRend.color = lowHealthColor;
        }
        else
        {
            spriteRend.color = laptopColor;
        }



        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rigidBody.velocity = new Vector2(x, y) * movementSpeed;

        // laptop.position = new Vector3(laptop.position.x + (movementSpeed * x),laptop.position.y + (movementSpeed *y),0);
    }


}
