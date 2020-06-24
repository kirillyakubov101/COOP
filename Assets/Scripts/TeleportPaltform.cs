using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPaltform : MonoBehaviour
{
	[SerializeField] GameObject light;
	[SerializeField] Transform startPos;
	[SerializeField] Transform endPos;
	[SerializeField] float delayTime = 1.5f;
	[SerializeField] Vector3 topOffset = new Vector3(0f, 2f, 0f);

	Player player;

	// Start is called before the first frame update
	void Start()
	{
		light.SetActive(false);
		player = FindObjectOfType<Player>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == player.gameObject)
		{
			light.SetActive(true);
			StartCoroutine(Teleport());
			//other.gameObject.transform.position = endPos.position;
		}
	}

	IEnumerator Teleport()
	{
		yield return new WaitForSeconds(delayTime);
		player.transform.position = endPos.position + topOffset; 
	}

}
