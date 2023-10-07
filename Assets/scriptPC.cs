using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scriptPC : MonoBehaviour
{

	public LayerMask layerMask;
	public float rayDistance = 1;
	public float velocity = 5.5f;
	public float jumpForce = 420;
	private bool onFloor = false;
	private Rigidbody2D rbody;
	// Animations
	private Animator anim;
	private bool right = true;

	// Start is called before the first frame update
	void Start()
	{
		rbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		onFloor = true;
		// Only set the parent of PC when collides with GameObject
		// that has the tag "platform"
		if (collision.gameObject.tag == "platform")
		{
			transform.SetParent(collision.transform);
		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		onFloor = false;
		// Only unset the parent of PC when collides with platform
		if (collision.gameObject.CompareTag("platform"))
		{
			transform.SetParent(null, true);
		}
	}

	// Update is called once per frame
	void Update()
	{
		// Move horizontally
		float x = Input.GetAxis("Horizontal");
		rbody.velocity = new Vector2(x * velocity, rbody.velocity.y);

		// Animator
		if (x == 0) anim.SetBool("idle", true);
		else anim.SetBool("idle", false);

		// Flip animation when walking
		if ((right && x < 0) || (!right && x > 0))
		{
			right = !right;
			transform.Rotate(new Vector2(0, 180));
		}

		// Jump
		if (Input.GetKeyDown(KeyCode.Space) && onFloor)
		{
			onFloor = false;
			rbody.AddForce(new Vector2(0, jumpForce));
		}

		// Kill enemy when jumping on its head
		RaycastHit2D hit;
		hit = Physics2D.Raycast(transform.position, -transform.up, rayDistance, layerMask);
		Debug.DrawRay(transform.position, -transform.up * rayDistance, Color.red);
		if (hit.collider != null)
		{
			Debug.Log("Kill enemy.");
			Destroy(hit.collider.gameObject);
		}
	}
}
