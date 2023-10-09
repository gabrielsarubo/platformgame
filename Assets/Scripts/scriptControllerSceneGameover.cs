using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptControllerSceneGameover : MonoBehaviour
{
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			// Go back to Start
			SceneManager.LoadSceneAsync(0);
		}
	}
}
