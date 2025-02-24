using UnityEngine;

public class test2 : MonoBehaviour
{
	public GameObject x;

	public Transform Olexa;

	public Transform Stepka;

	public int LightIntens;

	public float rotate;

	private void Update()
	{
		if (Input.GetKey(KeyCode.W))
		{
			rotate -= 0.3f;
			Olexa.position += new Vector3(0f, 0f, 0.1f);
			Olexa.rotation = Quaternion.Euler(0f, rotate, 0f);
		}
		if (Input.GetKey(KeyCode.S))
		{
			rotate += 0.3f;
			Olexa.position -= new Vector3(0f, 0f, 0.1f);
			Olexa.rotation = Quaternion.Euler(0f, rotate, 0f);
		}
	}
}
