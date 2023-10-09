using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptControllerGameScene : MonoBehaviour
{
	private bool isGamePaused = false;

	// Update is called once per frame
	void Update()
	{
		// Load Pause scene when pressing Esc
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (isGamePaused)
			{
				Time.timeScale = 1;
			}
			else
			{
				Time.timeScale = 0;
				SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
			}
			isGamePaused = !isGamePaused;
		}
	}
}
