using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLife : MonoBehaviour
{
	// add life ................................IT15099600
	private void OnTriggerEnter2D(Collider2D col)
	{
		
		if (col.gameObject.CompareTag("Player"))
		{
			LifeControlScript.health += 1;

			if (col.gameObject.CompareTag("Life"))
			{
				Destroy(col.gameObject);
			}

		}
	}

		
	

}
