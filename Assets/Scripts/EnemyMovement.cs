using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	// Adjust the speed for the application.
	public float speed = 1.0f;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		float step = speed * Time.deltaTime; // calculate distance to move
											 // Spin the object around the world origin at 20 degrees/second.
		transform.RotateAround(Vector3.zero, Vector3.up, 5 * Time.deltaTime);
		transform.position = Vector3.MoveTowards(transform.position, Vector3Int.zero, step);
	}
}