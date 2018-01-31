using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jellyEnemyMove : MonoBehaviour {

	//Rigidbody2D jrb2D; 
	private bool jellyDown = true; 
	float jellyMoveSpeed = 1.75f; 


	// Use this for initialization
	void Start () 
	{
	//	jrb2D = GetComponent<Rigidbody2D> (); 
	}


	// Update is called once per frame
	void Update ()
	{
		if(jellyDown) 
		{
			transform.Translate (Vector2.down * jellyMoveSpeed * Time.deltaTime);
		} 

		else 
		{
			transform.Translate (-Vector2.down * jellyMoveSpeed * Time.deltaTime); 
		}

		if (transform.position.y >= 1.0f)
		{
			jellyDown = true;
		}

		if (transform.position.y <= -3.75f) 
		{
			jellyDown = false; 
		}

	}
}
