using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
	public GameObject PC;
	public float offsetY = 2;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Vector3 camPos = new Vector3(PC.transform.position.x, PC.transform.position.y + offsetY, -10);
		transform.position = camPos;
	}
}
