using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float runSpeed;
    public float jumpForce;
    private SpriteRenderer spriteRend;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(x * runSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gravitybox"))
        {
            if (rb.gravityScale == 5)
            {
                rb.gravityScale = -5;
                spriteRend.flipY = false;
            }

            if (rb.gravityScale == -5)

            {
                rb.gravityScale = 5;
                spriteRend.flipY = true;
            }
        }
        else if (collision.CompareTag("danger"))
        {
            //Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

    }
}
