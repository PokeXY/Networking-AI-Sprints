using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Framework courtesy of Sebastian Graves
// A.I State Machine Made EASY (Unity) - January 10th, 2021
// https://www.youtube.com/watch?v=cnpJtheBLLY

public class StateManager : MonoBehaviour
{
    // The state that is currently active within the state machine
    // Make it publically accessible for testing
    public State currentState;

    // Update is called once per frame
    void Update()
    {
        RunStateMachine();
    }

    // Our state machine
    private void RunStateMachine()
    {
        // ? means if variable is not considered Null, run the sequence. Vice versa.
        // Setting our next state to be active state
        State nextState = currentState?.RunCurrentState();

        if (nextState != null)
        {
            // Setting the variable to the... next state available.
            SwitchToTheNextState(nextState);
        }
    }

    private void SwitchToTheNextState(State nextState)
    {
        // Switching our current state to the state that we're giving it / passing in
        currentState = nextState;
    }
}
