using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_script : MonoBehaviour
{
    int enemyValue = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            scoreManager.instance.ScoreFunction(enemyValue);
            Destroy(gameObject);
        }
    }
}
