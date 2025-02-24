using UnityEngine;
using UnityEngine.AI;

public class EnemyHP : MonoBehaviour
{
	public int WOOLFHP;

	public Animator MyAnimator;

	public Enemy EnemyScript;

	public NavMeshAgent MyAgent;

	private void Update()
	{
		if (WOOLFHP <= 0)
		{
			EnemyScript.enabled = false;
			MyAnimator.Play("Die");
			MyAgent.enabled = false;
			Object.Destroy(base.gameObject, 5f);
		}
	}
}
