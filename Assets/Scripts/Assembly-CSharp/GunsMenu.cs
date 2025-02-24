using UnityEngine;
using UnityEngine.EventSystems;

public class GunsMenu : MonoBehaviour
{
	public GameObject Buttons;

	public GameObject[] Guns;

	private int currentGun;

	private void Start()
	{
		Guns[0].SetActive(value: true);
	}

	public void NextGun()
	{
		Guns[currentGun].SetActive(value: false);
		currentGun++;
		if (currentGun >= Guns.Length)
		{
			currentGun = 0;
		}
		Guns[currentGun].SetActive(value: true);
	}

	public void PreviousGun()
	{
		Guns[currentGun].SetActive(value: false);
		currentGun--;
		if (currentGun < 0)
		{
			currentGun = Guns.Length - 1;
		}
		Guns[currentGun].SetActive(value: true);
	}

	private void Update()
	{
		if ((Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)))
		{
			Buttons.SetActive(value: false);
		}
		else if (Input.touchCount == 0 && !Input.GetMouseButton(0))
		{
			Buttons.SetActive(value: true);
		}
	}
}
