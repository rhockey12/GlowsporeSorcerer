using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollision : MonoBehaviour
{
    [HideInInspector]
    public float damage;
    void OnTriggerEnter(Collider collision)
    {
        Health health;
        health = collision.gameObject.GetComponent<Health>();
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (health != null)
            {
                health.TakeDamage(damage);
            }
        }
    }
}
