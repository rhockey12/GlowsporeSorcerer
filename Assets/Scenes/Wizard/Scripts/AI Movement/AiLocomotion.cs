using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiLocomotion : MonoBehaviour
{

    public Transform playerTransform;
    public float maxTime = 1.0f;
    public float maxDistance = 2.0f;

    NavMeshAgent agent;
    float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0.0f)
        {
            float sqDistance = (playerTransform.position - agent.destination).sqrMagnitude;
            if (sqDistance > (maxDistance*maxDistance)) 
            {
                agent.destination = playerTransform.position;
            }
            timer = maxTime;
        }
    }
}
