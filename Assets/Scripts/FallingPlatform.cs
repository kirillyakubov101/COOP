using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
	[SerializeField] float delayTime = 1.5f;

	Animator animator;

    // Start is called before the first frame update
    void Start()
    {
		animator = GetComponent<Animator>();
	}

	private void OnTriggerEnter(Collider other)
	{
		StartCoroutine(FallDown());
	}

	IEnumerator FallDown()
	{
		yield return new WaitForSeconds(delayTime);
		animator.SetTrigger("Fall");
	}
}
