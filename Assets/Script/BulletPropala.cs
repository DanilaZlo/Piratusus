using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPropala : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
        }

    }


}
