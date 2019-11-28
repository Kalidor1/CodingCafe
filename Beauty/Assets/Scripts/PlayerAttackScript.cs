using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    public float attackSpeed = 1f;
    private float timer;

    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Mouse0) && timer <= 0)
        {
            print("ATTACK!");
            anim.SetTrigger("attack");
            timer = attackSpeed;
        }
    }
}
