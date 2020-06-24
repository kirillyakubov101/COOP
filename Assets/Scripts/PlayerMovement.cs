using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public static bool isGrounded = true;

	[SerializeField] float speed = 20f;
	[SerializeField] float yDeath = -5f;

	float Horizontal,Vertical;
	Rigidbody rb;
	

	// Start is called before the first frame update
	void Start()
    {
		rb = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update()
	{
		CheckDeath();
		ProcessInput();
	}

	private void ProcessInput()
	{
		if (isGrounded)
		{
			Horizontal = CrossPlatformInputManager.GetAxis("Horizontal") * speed;
			Vertical = CrossPlatformInputManager.GetAxis("Vertical") * speed;

		}
	}

	private void CheckDeath()
	{
		if (transform.position.y < yDeath)
		{
			SendMessage("Die");
		}
	}

	private void FixedUpdate()
	{
		rb.AddForce(Horizontal,0f, Vertical);
	}

	
}
