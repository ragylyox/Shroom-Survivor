using UnityEngine.SceneManagement;
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
			float hp = HP.value - DamageAmount;
			if(hp <= 0)
			{
                SceneManager.LoadScene("Menue");
            }
			else
			{
                HP.value = hp;
            }
		}
	}
}
