using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The Raycast logic for this Enemy is considering that the sprite
 * of this enemy is "flipped on the X axis" (Component Sprite Renderer > Flip)
 * that way, the enemy begins by looking towards the right side of screen
*/
public class scriptEnemy : MonoBehaviour
{
	public LayerMask layerMask;// on the UI, select "Collidable"
	private Rigidbody2D rbody;
	public float speed = 3;
	// Start is called before the first frame update
	void Start()
	{
		rbody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		rbody.velocity = new Vector2(speed, 0);

		RaycastHit2D hit;
		/* 
			Parameters of Raycast
			origin point of the ray, ie. where it is coming from
			direction of the ray, eg. always to the right (consider right as its front)
			distance, ie the range of the ray, identify proximity
			layer mask in this case represents the Layer "Collidable", previously created
			in the UI in Unity
		*/
		hit = Physics2D.Raycast(transform.position, transform.right, 0.6f, layerMask);

		if (hit.collider != null)
		{
			speed *= -1;
			rbody.velocity = new Vector2(speed, 0);
			transform.Rotate(new Vector2(0, 180));
		}
	}
}
