using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrol : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    public float distance;
    private bool movingRight = true;
    public Transform groundDetection;
    public float wallDistance;

    Vector2 changingVector = new Vector2();


    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        RaycastHit2D WallInfo = Physics2D.Raycast(groundDetection.position, changingVector, wallDistance);
     

        if (WallInfo == true)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
                changingVector = new Vector2(-1, 0);
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
                changingVector = new Vector2(1, 0);
            }
        }

        if (groundInfo == false)
        {
            if(movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;

            }
        }
    }
}
