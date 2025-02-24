using UnityEngine;

public class CubDestroy : MonoBehaviour
{
	public void OnTriggerEnter(Collider other)
	{
		Object.Destroy(base.gameObject);
	}
}
