using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemyHealth2 : MonoBehaviour
{
    [Header("Stats")]
    public float enemyMaxHealth = 100f;
    private float enemyCurrentHealth;
    public GameObject main;
    public TextMeshProUGUI enemyHealthText;

    [Header("Sounds")]
    public AudioSource enemySFX;
    public AudioClip hurtSound;
    [Header("VFX")]
    public GameObject bloodParticles;


    // Start is called before the first frame update
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
        updateHealthUI();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerWeapon"))
        {
            float damageToTake = collision.gameObject.GetComponent<AxeController>().damage;
            enemyCurrentHealth -= damageToTake;
            
            updateHealthUI();
            playHurtSound();
            Camera.main.GetComponent<cameraShake>().Shake(); // store component in order to call smth from within or just add at end

            if (enemyCurrentHealth <= 0)
            {
                deathParticles();
                enemyDeath();
             
            }

        }
        else if (collision.CompareTag("Player"))
        {
           // collision.gameObject.GetComponent<PlayerMovement>().KillPlayer();
        }
    }

    private void deathParticles()
    {
        Instantiate(bloodParticles, transform.position, Quaternion.identity);
    }
    public void updateHealthUI()
    {
        if (enemyCurrentHealth == enemyMaxHealth || enemyCurrentHealth <= 0)
        {
            enemyHealthText.text = null;
        }
        else
        {
            enemyHealthText.text = enemyCurrentHealth.ToString();
        }
    }


    private void playHurtSound()
    {
        enemySFX.PlayOneShot(hurtSound);

    }
    private void enemyDeath()
    {
        Destroy(main);
    }
}
