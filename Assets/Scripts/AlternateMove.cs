using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternateMove : MonoBehaviour
{
	[SerializeField] private bool isFollowPaltformActive = true;
	[SerializeField] private GameObject Player;
	[SerializeField] private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
		Move();
    }

	private void Move()
	{
		transform.position += Vector3.right * Mathf.Sin(Time.time) * speed * Time.deltaTime;//Adjust
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == Player && isFollowPaltformActive)
		{
			Player.transform.parent = transform;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject == Player && isFollowPaltformActive)
		{
			Player.transform.parent = null;
		}
	}
}
