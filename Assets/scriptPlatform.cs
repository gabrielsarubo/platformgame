using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlatform : MonoBehaviour
{
	private float counter = 0;
	public float velocity = 3;
	private Vector2 posInitial;
	public float radiusX = 1;
	public float radiusY = 0;
	// Start is called before the first frame update
	void Start()
	{
		posInitial = transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		// calculate displacement, not velocity, thus deltaTime
		counter += velocity * Time.deltaTime;
		// find X, Y axis to get the current position
		float posX = Mathf.Cos(counter) * radiusX;
		float posY = Mathf.Sin(counter) * radiusY;
		Vector2 posCurrent = new Vector2(posX, posY);
		// sum with initial position with current position to get the next position
		transform.position = posInitial + posCurrent;
		// prevent counter from going to infinity
		if (counter >= 2 * Mathf.PI)
			counter = 2 * Mathf.PI - counter;
	}
}
