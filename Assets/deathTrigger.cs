using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathTrigger : MonoBehaviour
{



	// Update is called once per frame
	private void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);

	}
}
