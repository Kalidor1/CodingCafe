using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private Animator anim;
    private SpriteRenderer spriteRend;

    [Header("Movement")]
    public float speed;
    public float JumpPower;
    public bool grounded = false;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        spriteRend = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        //intermediary varialbe
        float modifiedSpeed = xInput * speed;
        rigidbody.velocity = new Vector2(modifiedSpeed, rigidbody.velocity.y);

        if (Input.GetButtonDown("JumpButton") && grounded)
        {
            // can add force or velocity in 2 ways:

            //rigidbody.AddForce(new Vector2(0f, JumpPower));
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, JumpPower);
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
            //spriteRend.flipX = false;
            transform.localScale = new Vector3(1, 1, 1); 
            //-> if you want to flip whole character
        }
        else if (xInput < 0f)
        {
            //spriteRend.flipX = true;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
