using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Animator anim;
    public float attackSpeed = 1f;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Mouse0) && timer <= 0)
        {
            print("hi");
            timer = attackSpeed;
            anim.SetTrigger("Attack");
            
        }
    }
}
