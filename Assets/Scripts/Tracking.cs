using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Tracking : MonoBehaviour
{
    public Transform Target;
    public float UpdateSpeed = 0.1f; //how frequently path based on target transforms position

    private NavMeshAgent Agent;

    private void Awake()
    {
        Agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        StartCoroutine(FollowTarget());
    }
    private IEnumerator FollowTarget()
    {
        WaitForSeconds Wait = new WaitForSeconds(UpdateSpeed);

        while (enabled)
        {
            Agent.SetDestination(Target.transform.position);

            yield return Wait;
        }
    }
}
