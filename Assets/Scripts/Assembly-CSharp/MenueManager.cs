using UnityEngine;
using UnityEngine.SceneManagement;

public class MenueManager : MonoBehaviour
{
	public void StartGameNew()
	{
		SceneManager.LoadScene("level Sasha");
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void Update()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
}
