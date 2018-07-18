﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {

	public enum EnemyStates { Idle, Chase};
    EnemyStates states;
    NavMeshAgent navMeshAgent;
    public Transform FollowTarget;
    public GameObject[] PatrolPoints;
    public Collider[] other;
    GameObject CurrentPoint;
    public float radius = 3f;

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        PatrolPoints = GameObject.FindGameObjectsWithTag("PatrolPoint");
        CurrentPoint = PatrolPoints[0];
        states = EnemyStates.Idle;
    }

    void Update()
    {


        other = Physics.OverlapSphere(this.transform.position, 1.5f);

        foreach(Collider c in other)
        {
            if(c.gameObject.tag == "Player")
            {
                states=EnemyStates.Chase;
            }else
            {
                states = EnemyStates.Idle;
            }
        }
        //When to change to Idle
        //When to change to Chase
        //if (Vector3.Distance(navMeshAgent.transform.position, FollowTarget.transform.position) < 3)
        //{
        //    states = EnemyStates.Chase;
        //}else if(Vector3.Distance(navMeshAgent.transform.position, FollowTarget.transform.position) > 3)
        //{
        //    states = EnemyStates.Idle;
        //}

        AIStates(states);
    }

    public void AIStates(EnemyStates states)
    {
        switch (states)
        {
            case EnemyStates.Idle:

                navMeshAgent.SetDestination(CurrentPoint.transform.position);

                if (Vector3.Distance(navMeshAgent.transform.position, PatrolPoints[1].transform.position) < 0.5f)
                {
                    CurrentPoint = PatrolPoints[0];
                }
                else if (Vector3.Distance(navMeshAgent.transform.position, PatrolPoints[0].transform.position) < 0.5f)
                {
                    CurrentPoint = PatrolPoints[1];
                }
                //WHat happens in Idle State

                break;
            case EnemyStates.Chase:
                navMeshAgent.SetDestination(FollowTarget.position);
                navMeshAgent.stoppingDistance = 0.5f;
                //What happens in Chase State
                break;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);

    }
}
