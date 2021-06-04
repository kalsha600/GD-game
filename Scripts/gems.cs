using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gems : MonoBehaviour
{
	// add gems ................................IT15099600
	public int gemValue = 1;


	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			ScoreManager.instance.ChangeScore2(gemValue);
		}
	}
}
