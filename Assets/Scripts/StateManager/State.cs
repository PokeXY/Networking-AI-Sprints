using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Framework courtesy of Sebastian Graves
// A.I State Machine Made EASY (Unity) - January 10th, 2021
// https://www.youtube.com/watch?v=cnpJtheBLLY

// Cannot use this class specifically, but only classes that inherit from it
public abstract class State : MonoBehaviour
{
    // Returns the current state
    public abstract State RunCurrentState();
}
