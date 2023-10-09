using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptBackgroundTree : MonoBehaviour
{
	private Rigidbody2D rbody;
	public float speed = 2;
	// Camera
	private float cameraWidth;
	private float cameraHeight;

	// Start is called before the first frame update
	void Start()
	{
		rbody = GetComponent<Rigidbody2D>();
		rbody.velocity = new Vector2(-speed, 0);

		cameraHeight = Camera.main.orthographicSize;
		cameraWidth = cameraHeight * Camera.main.aspect;
	}

	// Update is called once per frame
	void Update()
	{
		if (transform.position.x < (cameraWidth * -2))
		{
			transform.position = new Vector2(cameraWidth * 2, -7);
		}
	}
}
