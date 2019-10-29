using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGroundCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public controller playerMovement;


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") //collision.gameObject.CompareTag("Ground") also works
        {
            playerMovement.grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            playerMovement.grounded = false;
        }
    }
    //private void OnTriggerEnter2D(Collider2D collision) function -> will always activate if there is 1 trigger 
    //- so collider with trigger also works
}
