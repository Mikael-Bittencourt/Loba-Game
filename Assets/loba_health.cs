using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loba_health : MonoBehaviour
{
     public int maxHealth = 100;
     public int currentHealth;
     public HealthBar healthBar = new HealthBar();

     public GameObject DeathMenu;
     

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start: " + healthBar);
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
      if(currentHealth == 0)
        {
            die();
        } else if (Input.GetKeyDown(KeyCode.Space))
    {
        TakeDamage(20);
    }

 
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
    }

    void die()
    {
        Destroy(gameObject);
        DeathMenu.SetActive(true);
    }

   public void OnTriggerEnter2D (Collider2D other)
   {
     if(other.CompareTag("zombie"))
     {
         TakeDamage(20);
     }
   }

}
