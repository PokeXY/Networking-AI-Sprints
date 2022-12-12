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
    public override State RunCurrentState()
    {
        // If the player is in attack range, the enemy attempts to strike;
        if (isInAttackRange)
        {
            return attackState;
        }
        else
        {
            return this;
        }

    }
}
