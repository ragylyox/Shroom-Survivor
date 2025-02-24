using UnityEngine;

public class test3 : MonoBehaviour
{
	public GameObject toRotate;

	public Transform x;

	public Transform y;

	public float mb;

	private void Update()
	{
		if (Input.GetKey(KeyCode.S))
		{
			mb -= 0.5f;
			x.rotation = Quaternion.Euler(mb, 0f, 0f);
			x.position += new Vector3(0f, 0f, 0.1f);
		}
		if (Input.GetKey(KeyCode.W))
		{
			mb += 0.5f;
			x.rotation = Quaternion.Euler(mb, 0f, 0f);
			x.position -= new Vector3(0f, 0f, 0.1f);
		}
	}
}
