using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crabEnemyMove : MonoBehaviour {

	//Rigidbody2D crb2D;  
	private bool crabRight = true; 
	float crabMoveSpeed = 2.0f; 


	// Use this for initialization
	void Start () 
	{
	//crb2D = GetComponent<Rigidbody2D> (); 
	}


	// Update is called once per frame
	void Update () 
	{
		if (crabRight) 
		{
			transform.Translate (Vector2.right * crabMoveSpeed * Time.deltaTime);
		} 

		else 
		{
			transform.Translate (-Vector2.right * crabMoveSpeed * Time.deltaTime); 
		}


		if (transform.position.x >= 3.95f)
		{
			crabRight = false;
		}

		if (transform.position.x <= -2.95f) 
		{
			crabRight = true; 
		}
			

	}
}
