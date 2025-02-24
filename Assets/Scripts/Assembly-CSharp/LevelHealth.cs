using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelHealth : MonoBehaviour
{
	public int levelHealth = 100;

	public Slider mySlider;

	public Image myImage;

	public Camera maincamera;

	private void Update()
	{
		mySlider.value = levelHealth;
		if (levelHealth < 10)
		{
			myImage.enabled = false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		if (levelHealth <= 0)
		{
			SceneManager.LoadScene("Menue");
		}
		else
		{
			myImage.enabled = true;
		}
	}
}
