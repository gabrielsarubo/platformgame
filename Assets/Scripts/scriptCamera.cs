using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
	public GameObject PC;
	public float offsetY = 2;
	private Bounds _cameraBounds;

	// Start is called before the first frame update
	void Start()
	{
		var minX = 0;
		var maxX = 41;

		var minY = -12;
		var maxY = 0;

		_cameraBounds = new Bounds();
		_cameraBounds.SetMinMax(
			new Vector3(minX, minY, 0.0f),
			new Vector3(maxX, maxY, 0.0f)
		);
	}

	void LateUpdate()
	{
		var x = PC.transform.position.x;
		var y = PC.transform.position.y + offsetY;
		var z = -10;

		var _targetPosition = GetCameraBounds(x, y, z);

		transform.position = _targetPosition;
	}

	private Vector3 GetCameraBounds(float x, float y, float z)
	{
		return new Vector3(
			Mathf.Clamp(x, _cameraBounds.min.x, _cameraBounds.max.x),
			Mathf.Clamp(y, _cameraBounds.min.y, _cameraBounds.max.y),
			z
		);
	}
}
