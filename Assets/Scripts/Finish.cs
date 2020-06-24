using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
	[SerializeField] ParticleSystem FinishVFX;

	


	private void OnTriggerEnter(Collider other)
	{
		
		FinishVFX.Play();
	}
}
