using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PFreezeSpell : MonoBehaviour
{
    Health health;
    NavMeshAgent agent;

    private bool collided = false;

    private float nextTimeToFreeze = 0f;
    private float freezeTime = 3f;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            health = collision.gameObject.GetComponent<Health>();
            Transform current = collision.transform;
            while (health != null)
            {
                current = current.parent;
                health = current.gameObject.GetComponent<Health>();
            }
            if (health != null)
            {
                collided = true;
            }
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (collided && Time.time >= nextTimeToFreeze)
        {
            nextTimeToFreeze = Time.time + freezeTime;
            Freeze();
        }
    }

    void Freeze()
    {
        if (health != null)
        {
            agent.speed = 0;
        }
    }
}