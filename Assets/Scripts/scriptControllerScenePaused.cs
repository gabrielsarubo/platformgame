using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptControllerScenePaused : MonoBehaviour
{

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			// Resume game
			SceneManager.UnloadSceneAsync(2);
		}
		else if (Input.GetKeyDown(KeyCode.Backspace))
		{
			// Restart the game
			SceneManager.LoadSceneAsync(0);
		}
	}
}
