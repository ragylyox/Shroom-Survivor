using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
	public NavMeshAgent myAgent;

	private float distance;

	public Transform target;

	public Animator myAnimator;

	private float attackCooldown = 1.5f;

	private float lastAttackTime;

	private void Update()
	{
		distance = Vector3.Distance(target.position, base.transform.position);
		if (distance > 150f)
		{
			myAgent.enabled = false;
			myAnimator.Play("Idle");
		}
		else if (distance <= 150f && distance > 4f)
		{
			myAgent.enabled = true;
			myAgent.SetDestination(target.position);
			myAnimator.Play("Run");
		}
		else if (distance <= 4f)
		{
			myAgent.enabled = false;
			if (Time.time - lastAttackTime > attackCooldown)
			{
				PerformRandomAttack();
				lastAttackTime = Time.time;
			}
		}
	}

	private void PerformRandomAttack()
	{
		if (Random.Range(0, 2) == 0)
		{
			myAnimator.Play("Attack1");
		}
		else
		{
			myAnimator.Play("Attack2");
		}
	}
}
