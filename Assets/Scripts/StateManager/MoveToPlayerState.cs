using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Framework courtesy of Sebastian Graves
// A.I State Machine Made EASY (Unity) - January 10th, 2021
// https://www.youtube.com/watch?v=cnpJtheBLLY

// Calling functions from our Abstract Class State
public class MoveToPlayerState : State
{
    public AttackPlayerState attackState;
    public bool isInAttackRange;
    public GameObject player;
    public GameObject parent;
    private float speed = 1.0f;
    private float distance;
    private float distanceToPlayer;

    public override State RunCurrentState()
    {
        parent = GameObject.FindWithTag("Enemy");
        distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        distance = Vector3.Distance(parent.transform.position, player.transform.position);
        Vector3 direction = player.transform.position - parent.transform.position;
        parent.transform.position = Vector3.MoveTowards(parent.transform.position, player.transform.position, speed * Time.deltaTime);

        // If the player is in attack range, the enemy attempts to strike;
        if (distanceToPlayer < 3.0)
        {
            return attackState;
        }
        else
        {
            return this;
        }

    }
}
