using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent myAgent;
    private float distance;
    public Transform target;
    public Animator myAnimator;


    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);

        if (distance > 15)
        {
            myAgent.enabled = false;
            myAnimator.Play("Idle");
        }
        if (distance < 15 & distance > 1)
        {
            myAgent.enabled = true;
            myAgent.SetDestination(target.position);
            myAnimator.Play("Run");
        }
        if (distance <= 1)
        {
            myAnimator.Play("Attak");
            myAgent.enabled = false;
        }
    }
}


