using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Framework courtesy of Sebastian Graves
// A.I State Machine Made EASY (Unity) - January 10th, 2021
// https://www.youtube.com/watch?v=cnpJtheBLLY

// Calling functions from our Abstract Class State
public class MoveToObjectiveState : State
{

    public GameObject goal;
    public GameObject parent;
    public GameObject player;
    public bool canSeePlayer;
    public MoveToPlayerState targetPlayer;
    private float speed = 1.0f;
    private float distance;
    private float distanceToPlayer;
    private float distanceToGoal;

    private UnityEngine.AI.NavMeshAgent agent;
    public override State RunCurrentState()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        distanceToGoal = Vector3.Distance(transform.position, goal.transform.position);

        // If the player is within view distance, target them instead
        if (distanceToPlayer < distanceToGoal)
        {

            return targetPlayer;

        }
        else
        {
            parent = GameObject.FindWithTag("Enemy");
            distance = Vector3.Distance(parent.transform.position, goal.transform.position);
            Vector3 direction = goal.transform.position - parent.transform.position;
            parent.transform.position = Vector3.MoveTowards(parent.transform.position, goal.transform.position, speed * Time.deltaTime);
            return this;
        }

    }
}
