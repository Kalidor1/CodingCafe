using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject catObject;
    public float projectileForwardForce;
    public float y1;
    private bool isReady;
    public float timeBetweenShots;
    private float timestamp;
    public bool facingRight = true;
    private float moveInput;
    public GameObject myObject;
    public GameObject dog;
    void Start()
    {

        dog = GameObject.Find("dog");
        BoxCollider2D dog2 = dog.GetComponent<BoxCollider2D>();
        Rigidbody2D dog3 = dog.GetComponent<Rigidbody2D>();
    }


    //Instantiate(catObject, transform.position, Quaternion.identity);




    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        
        if (moveInput > 0)
        {
            facingRight = true;
        }
        else if (moveInput < 0)
        {
            facingRight = false;
        }     

        if (Input.GetKey(KeyCode.LeftShift) && Time.time >= timestamp && facingRight == true)
        {
            myObject = Instantiate(catObject, transform.position, Quaternion.identity);
            myObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(projectileForwardForce, y1));
            Destroy(myObject, 2);
            timestamp = Time.time + timeBetweenShots;
        }
        if (myObject.scene.IsValid() && dog.scene.IsValid())
            {
            if (myObject.GetComponent<BoxCollider2D>().IsTouching(dog.GetComponent<BoxCollider2D>()))
            {
                Debug.Log("HIT");
                Destroy(myObject);
                Destroy(dog);
            }
            // trying to access destoyed game object error
            }
        if (Input.GetKey(KeyCode.LeftShift) && Time.time >= timestamp && facingRight == false)
        {
            GameObject myObject = Instantiate(catObject, transform.position, Quaternion.identity);
            myObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-projectileForwardForce, y1));
            Destroy(myObject, 2);
            timestamp = Time.time + timeBetweenShots;
        }


    }
}
