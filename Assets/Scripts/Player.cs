using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed;
    int currentHealth;
    int jumpForce;
    int maxHealth;
    int lives;

    [SerializeField]
    private Rigidbody2D rb;

    public void Jump()
    {
        rb.AddForce(new Vector2(0,jumpForce));
    }

    public void Move()
    {
        rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Death();
        }
    }

    public void SetHealth(int amount)
    {
        if(amount <= maxHealth)
        {
            currentHealth = amount;
        }
    }

    public void UsePowerUp(int id)
    {
        if(id == 1)
        {
            if(currentHealth < maxHealth)
            {
                TakeDamage(-1);
            }
        }
        else if(id == 2)
        {
            if(currentHealth < maxHealth)
            {
                SetHealth(maxHealth);
            }
        }
    }

    public void ChangeLives(int amount)
    {
        lives += amount;
    }

    public virtual void Death()
    {
        Destroy(gameObject);
    }
}
