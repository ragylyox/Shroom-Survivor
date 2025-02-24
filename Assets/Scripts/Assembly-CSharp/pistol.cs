using UnityEngine;

public class pistol : MonoBehaviour
{
	public GameObject pylaPrefab;

	public Transform shootingPoint;

	public float shootingForce = 500f;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Shoot();
		}
	}

	private void Shoot()
	{
		GameObject gameObject = Object.Instantiate(pylaPrefab, shootingPoint.position, shootingPoint.rotation);
		Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
		if (rigidbody == null)
		{
			rigidbody = gameObject.AddComponent<Rigidbody>();
		}
		rigidbody.AddForce(shootingPoint.forward * shootingForce);
		Object.Destroy(gameObject, 10f);
	}
}
