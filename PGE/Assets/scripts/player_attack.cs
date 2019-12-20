using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_attack : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
           GameObject tempBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            tempBullet.GetComponent<bullet_manager>().Spawn(transform.right);
           



        }
    }
}
