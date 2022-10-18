using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.AI;

public class Follower : MonoBehaviour
{
    private NavMeshAgent follower;
    public Transform LeaderTarget;


    // Start is called before the first frame update
    void Start()
    {
        follower = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        follower.SetDestination(LeaderTarget.position);
    }
}
