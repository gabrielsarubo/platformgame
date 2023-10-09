using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptGameController : MonoBehaviour
{
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			// Start game
			SceneManager.LoadSceneAsync(1);
		}
		else if (Input.GetKeyDown(KeyCode.Escape))
		{
			// Exit game 
			Application.Quit();
		}
	}
}
