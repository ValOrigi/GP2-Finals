using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNavigation : MonoBehaviour
{
	public void OnPlayButton()
	{
		SceneManager.LoadScene(2);
	}
	
	public void OnControlsButton()
	{
		SceneManager.LoadScene(1);
	}	
	
	public void OnBackButton()
	{
		SceneManager.LoadScene(0);
	}

	public void OnRestartButton()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void OnQuitButton()
	{
		Application.Quit();
	}
}
