using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FleeingAI : MonoBehaviour
{
    private NavMeshAgent agent;

    public GameObject Player;

    public float EnemyDistanceRun = 4f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // get distance from player to enemy
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        
        // if distance is lower than enemies distance
        if (distance < EnemyDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position + dirToPlayer;
            agent.SetDestination(newPos);
        }
    }
}
