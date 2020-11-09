using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
      Zombie zombie = hitInfo.GetComponent<Zombie>();
      if (zombie != null)
      {
        ScoreText.scoreValue += 10;
        zombie.TakeDamage(damage);
      }
      Destroy(gameObject);
    }
}
