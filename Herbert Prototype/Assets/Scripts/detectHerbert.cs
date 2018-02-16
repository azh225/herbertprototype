using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectHerbert : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D other )
	{
		if (other.gameObject.tag == "Player") 
		{
			CameraMovement.canMoveCamera = true;

			// using tags, make sure each collider has correct tag 

			if (transform.tag == "Left") {
				CameraMovement.currentDir = CameraMovement.Dir.left;

			} else if (transform.tag == "Right") {
				CameraMovement.currentDir = CameraMovement.Dir.right;

			} else if (transform.tag == "Top") {
				CameraMovement.currentDir = CameraMovement.Dir.up; 

			} else if (transform.tag == "Bottom") {
				CameraMovement.currentDir = CameraMovement.Dir.down;
			}

		}

	}

}
