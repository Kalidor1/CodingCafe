using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float speed;
    public float jumpPower;
    public bool grounded = false;

   
    private Rigidbody2D rigidbody;
    private Animator anim;
    private SpriteRenderer spriteRend;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float modifiedSpeed = xInput * speed;

        rigidbody.velocity = new Vector2(modifiedSpeed, rigidbody.velocity.y);

        if (Input.GetButtonDown("JumpButton") && grounded)
        {
            //rigidbody.AddForce(new Vector2(0f, jumpPower));
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpPower);
        }

        if (xInput != 0f && grounded)
        {
            anim.SetBool("walking", true);
        }
        else
        {
            anim.SetBool("walking", false);
        }

        if (xInput > 0f)
        {
            //transform.localScale = new Vector3(1, 1, 1);
            spriteRend.flipX = false;
        }
        else if (xInput < 0f)
        {
            //transform.localScale = new Vector3(-1, 1, 1);
            spriteRend.flipX = true;
        }
    }
        
}
