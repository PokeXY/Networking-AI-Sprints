using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Framework courtesy of Sebastian Graves
// A.I State Machine Made EASY (Unity) - January 10th, 2021
// https://www.youtube.com/watch?v=cnpJtheBLLY

// Calling functions from our Abstract Class State
public class AttackPlayerState : State
{

    public override State RunCurrentState()
    {
        Debug.Log("AttackState");
        return this;
    }
}
