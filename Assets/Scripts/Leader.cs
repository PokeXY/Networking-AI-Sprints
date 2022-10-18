using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.AI;

public class Leader : MonoBehaviour
{
    private NavMeshAgent leader;
    public Transform PlayerTarget;


    // Start is called before the first frame update
    void Start()
    {
        leader = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        leader.SetDestination(PlayerTarget.position);
    }
}
