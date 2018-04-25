using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScreenMovements : MonoBehaviour {

	private bool herbRight; 
	public float herbMoveSpeed = 5.0f; 
	public float moveThreshold = 5.5f; 
	float initPosX; 

	public SpriteRenderer herb; 

	void Start ()
	{
		herb = GetComponent<SpriteRenderer> (); 

		initPosX = transform.position.x; 
		int randomNum = Random.Range (0, 10); 

		if (randomNum > 5) {
			herbRight = true; 
		} else {
			herbRight = false; 
		}

	}

	void Update ()
	{
		if (herbRight) 
			transform.Translate (Vector2.right * herbMoveSpeed * Time.deltaTime); 
		else
			transform.Translate (-Vector2.right * herbMoveSpeed * Time.deltaTime); 


		if (transform.position.x >= initPosX + moveThreshold)
		{
			herbRight = false;

			if (this.gameObject.tag == "Player") 
			{
				herb.flipX = true; 
			}
		}

		if (transform.position.x <= initPosX - moveThreshold)
		{
			herbRight = true; 
			if (this.gameObject.tag == "Player") 
			{
				herb.flipX = false; 
			}		
		}

	}
}
