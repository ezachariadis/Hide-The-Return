using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

	public enum EnemyStates { Idle, Chase};
    EnemyStates states;
    NavMeshAgent navMeshAgent;
    public Transform FollowTarget;
    public GameObject[] PatrolPoints;
    GameObject CurrentPoint;

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        PatrolPoints = GameObject.FindGameObjectsWithTag("PatrolPoint");
        CurrentPoint = PatrolPoints[0];
        states = EnemyStates.Idle;
    }

    void Update()
    {

        //When to change to Idle
        //When to change to Chase
        if (Vector3.Distance(navMeshAgent.transform.position, FollowTarget.transform.position) < 3)
        {
            states = EnemyStates.Chase;
        }else if(Vector3.Distance(navMeshAgent.transform.position, FollowTarget.transform.position) > 3)
        {
            states = EnemyStates.Idle;
        }

        switch (states)
        {
            case EnemyStates.Idle:

                navMeshAgent.SetDestination(CurrentPoint.transform.position);

                if(Vector3.Distance(navMeshAgent.transform.position, PatrolPoints[1].transform.position) < 0.5f)
                {
                    CurrentPoint = PatrolPoints[0];
                }else if(Vector3.Distance(navMeshAgent.transform.position, PatrolPoints[0].transform.position) < 0.5f)
                {
                    CurrentPoint = PatrolPoints[1];
                }
                //WHat happens in Idle State

                break;
            case EnemyStates.Chase:
                navMeshAgent.SetDestination(FollowTarget.position);
                //What happens in Chase State
                break;
        }
    }
}
