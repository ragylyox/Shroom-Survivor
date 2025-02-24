using UnityEngine;
using UnityEngine.UI;

public class damage : MonoBehaviour
{
	public Slider HP;

	public int DamageAmount;

	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			HP.value -= DamageAmount;
		}
	}
}
