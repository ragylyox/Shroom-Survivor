using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mes : MonoBehaviour
{
	public int ShroomColected;

	public int ShroomTofinish;

	public Text ShroomText;

	public GameObject Enemy;

	private void Update()
	{
		ShroomText.text = "Mashroom colected :" + ShroomColected + "/" + ShroomTofinish;
		if (ShroomColected == 2)
		{
			Enemy.SetActive(value: true);
		}
		if (ShroomColected == 5)
		{
			SceneManager.LoadScene("Menue");
		}
	}
}
