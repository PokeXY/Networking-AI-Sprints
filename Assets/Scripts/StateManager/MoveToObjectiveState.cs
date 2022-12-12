using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Framework courtesy of Sebastian Graves
// A.I State Machine Made EASY (Unity) - January 10th, 2021
// https://www.youtube.com/watch?v=cnpJtheBLLY

// Calling functions from our Abstract Class State
public class MoveToObjectiveState : State
{
    public bool canSeePlayer;
    public MoveToPlayerState targetPlayer;
    public override State RunCurrentState()
    {
        // If the player is within view distance, target them instead
        if (canSeePlayer)
        {
            return targetPlayer;
        }
        else
        {
            return this;
        }

    }
}
