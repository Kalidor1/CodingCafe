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
    private float projectileUpForce = 0f;
    public bool facingRight = true;
    private float moveInput;
    void Start()
    {

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
            GameObject myObject = Instantiate(catObject, transform.position, Quaternion.identity);
            myObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(projectileForwardForce, y1));
            Destroy(myObject, 2);
            timestamp = Time.time + timeBetweenShots;
            
            
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
