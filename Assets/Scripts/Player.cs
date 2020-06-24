using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
   private void Die() //make a coroutine later pls
	{
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentSceneIndex);
	}

	private void OnCollisionStay(Collision collision)
	{
		if(collision.gameObject.tag == "Ground")
		{
			PlayerMovement.isGrounded = true;
		}
	
	}

	private void OnCollisionExit(Collision collision)
	{
		PlayerMovement.isGrounded = false;
	}


}
