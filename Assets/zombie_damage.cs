using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_damage : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
      Loba loba = hitInfo.GetComponent<Loba>();
      if (loba != null)
      {
        loba.TakeDamage(damage);
      }
      Destroy(gameObject);
    }
}
