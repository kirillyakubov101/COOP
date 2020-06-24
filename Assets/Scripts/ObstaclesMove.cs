using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMove : MonoBehaviour
{
	[SerializeField] Vector3 movementVector = new Vector3(10f, 10f, 10f);
	[SerializeField] float period = 2f;

	Rigidbody rb;
	Vector3 hitForce;

	float movementFactor;
	Vector3 startingPos;
	const float tau = Mathf.PI * 2f;  //6.283185

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		startingPos = transform.position;
		hitForce = new Vector3(10f, 10f, 10f);

	}

	// Update is called once per frame
	void FixedUpdate()
	{
		Oscillator();
	}

	private void Oscillator()
	{
		if (period <= Mathf.Epsilon) { return; }
		float cycles = Time.time / period;
		float rawSinWave = Mathf.Sin(cycles * tau);

		movementFactor = rawSinWave / 2f + 0.5f;


		Vector3 Offset = movementVector * movementFactor;
		transform.position = startingPos + Offset;
	}

}
