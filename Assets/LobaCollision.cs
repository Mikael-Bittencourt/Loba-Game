using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobaCollision : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
     public HealthBar healthBar;
    int damage=40;

    void start ()
    {
     currentHealth = maxHealth;
      healthBar.SetMaxHealth(maxHealth);
    }

    void Update ()
    {
    if(currentHealth == 0)
        {
            die();
        }
    }

   void OnCollision2DEnter(Collision _collision)
   {
     if(_collision.gameObject.tag=="zombie")
     {
       currentHealth -= damage;
       Debug.Log("zombie");
        healthBar.SetHealth(currentHealth);
     }
   }

   void die ()
   {
     Destroy(gameObject);
   }
   
}