using UnityEngine;

public class DoorController : MonoBehaviour
{
	public Animator myAnimator;

	public bool IsOpen;

	public GameObject Text;

	public void OnTriggerStay(Collider other)
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			Debug.Log("gwegwegw");
			IsOpen = !IsOpen;
			if (IsOpen)
			{
				myAnimator.Play("OpenDoor");
			}
			if (!IsOpen)
			{
				myAnimator.Play("CloseDoor");
			}
		}
	}

	public void OnTriggerExit(Collider other)
	{
	}
}
