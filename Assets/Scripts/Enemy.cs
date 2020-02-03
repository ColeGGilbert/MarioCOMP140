using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int health;
    public bool canJump;
    public int enemyID;
    public int damage;

    [SerializeField]
    private Rigidbody2D rb;

    public virtual void Attack(Player p)
    {
        p.TakeDamage(damage);
    }

    public void Move()
    {
        rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Death();
        }
    }

    public void ChangeDirection()
    {
        speed = -speed;
    }

    public virtual void Death()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        Move();

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Wall"))
        {
            speed = -speed;
        }
        if (col.transform.CompareTag("Player"))
        {
            Attack();
        }
    }
}
