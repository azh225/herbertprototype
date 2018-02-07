using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public static bool canMoveCamera; 

	public enum Dir {left, right}; 
	public static Dir currentDir; 

	Vector2 targetPos; 

	Vector2 lastPos; // this is noted when camera reaches new position

	// how much target moves 
	public float stepX = 35.0f; 
	public float stepY = 14.7f;


	float cameraSpeed = 10f; 


	// Use this for initialization
	void Start () {

		canMoveCamera = false; 
		lastPos = transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		if (canMoveCamera)
		{


			if (currentDir == Dir.left) {
				targetPos = new Vector2( lastPos.x - stepX, lastPos.y); 
			} else if (currentDir == Dir.right) {
				targetPos = new Vector2( lastPos.x + stepX, lastPos.y); 
			}


			// move camera
			transform.position = Vector2.MoveTowards(transform.position, targetPos, Time.deltaTime * cameraSpeed);
		}

		// once camera reaches new position, update last post 

		if (Vector2.Distance(transform.position, new Vector2(targetPos.x, targetPos.y)) <= 0.01f) {
			canMoveCamera = false;
			lastPos = targetPos;


		}

	}

}
