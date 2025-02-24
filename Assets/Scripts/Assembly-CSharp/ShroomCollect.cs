using UnityEngine;

public class ShroomCollect : MonoBehaviour
{
	public mes ShroomKounterScript;

	public void OnTriggerEnter(Collider other)
	{
		ShroomKounterScript.ShroomColected++;
		Object.Destroy(base.gameObject);
	}
}
