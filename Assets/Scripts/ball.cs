using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float maxSpeed = 1f;
    public Vector2 movement;

    public Rigidbody2D rb;
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag.Contains("block") || col.gameObject.name.Contains("Bottom")) {
            movement.x = Random.Range(-2f, 2f);

            rb.AddForce(movement * maxSpeed, ForceMode2D.Impulse);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        movement.x = Random.Range(-1f, 1f);
        
        rb.AddForce(movement * maxSpeed);
    }

}
