using UnityEngine;

public class BulletDamage : MonoBehaviour
{
	public int Damage;

	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy")
		{
			other.GetComponent<EnemyHP>().WOOLFHP -= Damage;
		}
	}
}
