using UnityEngine;

public class Shroom : MonoBehaviour
{
	public GameObject Text;

	public void OnTriggerStay(Collider other)
	{
		if (Input.GetKeyDown(KeyCode.F))
		{
			Object.Destroy(base.gameObject);
		}
	}

	public void OnTriggerExit(Collider other)
	{
	}
}
