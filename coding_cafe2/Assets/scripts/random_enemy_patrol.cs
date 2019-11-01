using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_patrol : MonoBehaviour
{
    public int speed;
    public Transform[] points;
    private int randomSpot;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        randomSpot = Random.Range(0, points.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[randomSpot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, points[randomSpot].position) < 0.5f)
        {
            if(waitTime <= 0)
            {
                randomSpot = Random.Range(0, points.Length);
            }
            else
            {
                waitTime -= waitTime - Time.deltaTime;
            }

        }
    }
}
