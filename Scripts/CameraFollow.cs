using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	// camera movements................................IT15099600
	public Transform target;
	public Vector3 offset;

	private void FixedUpdate()
	{
		transform.position = target.position + offset;
	}
}
