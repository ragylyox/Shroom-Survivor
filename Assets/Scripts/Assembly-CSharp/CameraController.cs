using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject CameraShed;

	public GameObject CameraFences;

	public GameObject CameraBridge;

	public GameObject CameraTools;

	private void Start()
	{
		EnableCamera("camShed");
		CameraFences.SetActive(value: false);
		CameraBridge.SetActive(value: false);
		CameraTools.SetActive(value: false);
	}

	public void EnableCamera(string camera)
	{
		if (camera == "camShed")
		{
			CameraShed.SetActive(value: true);
			CameraFences.SetActive(value: false);
			CameraBridge.SetActive(value: false);
			CameraTools.SetActive(value: false);
		}
		if (camera == "camTools")
		{
			CameraTools.SetActive(value: true);
			CameraShed.SetActive(value: false);
			CameraFences.SetActive(value: false);
			CameraBridge.SetActive(value: false);
		}
		if (camera == "camBridge")
		{
			CameraBridge.SetActive(value: true);
			CameraTools.SetActive(value: false);
			CameraShed.SetActive(value: false);
			CameraFences.SetActive(value: false);
		}
		if (camera == "camFences")
		{
			CameraFences.SetActive(value: true);
			CameraTools.SetActive(value: false);
			CameraShed.SetActive(value: false);
			CameraBridge.SetActive(value: false);
		}
	}
}
