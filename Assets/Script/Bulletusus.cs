using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletusus : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemi"))
        {
            Destroy(gameObject);
        }
    }
}
