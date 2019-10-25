using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_Controller : MonoBehaviour
{
    public float movementSpeed;
    public Transform laptop;
    public SpriteRenderer spriteRend;
    public Color laptopColor;
    public Color lowHealth;
    public Color extremeLow;
    public float healthDecrease = 5f;
    public Rigidbody2D rigidBody;

    private float moveInput;
    public float jumpForce;
    private bool isGrounded;
    public float radius;
    public LayerMask whatIsGround;
    public Transform GroundCheck;
    private bool facingRight = true;
   

    [Range(0, 100)]
    public float health;
    // Start is called before the first frame update
    void Start()
    {
     
        string name = "Laura";
        Debug.Log(name);

        spriteRend.color = laptopColor;

    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      
        if (Input.GetKey(KeyCode.Q))
        {
            health = health - 1 + healthDecrease * Time.deltaTime; //Decrease Health
        }
        else if (Input.GetKey(KeyCode.E))
        {
            health = health + 1 + healthDecrease * Time.deltaTime;
        }

        if (health > 50)
        {
            spriteRend.color = laptopColor;
        }

        else if (health < 50 && health > 25)
        {
            spriteRend.color = lowHealth;
        }
        else if (health < 25)
        {
            spriteRend.color = extremeLow;
        }
        moveInput = Input.GetAxisRaw("Horizontal");
        // laptop.position = new Vector3(laptop.position.x + (movementSpeed * x),laptop.position.y + (movementSpeed*y),0);
        rigidBody.velocity = new Vector2(moveInput * movementSpeed, rigidBody.velocity.y);

        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, radius, whatIsGround);

        
        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
        {
            rigidBody.velocity = Vector2.up * jumpForce;
        }

        if (facingRight == false && moveInput > 0)
        {
            Flip();
            
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
            
        }

        void Flip()
        {
            facingRight = !facingRight;
            Vector3 Scaler = transform.localScale;
            Scaler.x *= -1;
            transform.localScale = Scaler;
        }

    }
    void Update()
    {
      
    }
}
