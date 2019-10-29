using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class collision2 : MonoBehaviour
{

    public CapsuleCollider2D player;
    public BoxCollider2D dog;
    private float health2;
    private float healthDecrease2;
    // Start is called before the first frame updat
    void Start()

    {
        GameObject Laptop = GameObject.Find("Laptop");
        new_Controller cpu = Laptop.GetComponent<new_Controller>();
        new_Controller.healthDecrease = healthDecrease2;

    }

    // Update is called once per frame
    void Update()
    {
        if (player.IsTouching(dog))
        {
            new_Controller.health += -1;
            Debug.Log(new_Controller.health);

        }
       
    }
}
