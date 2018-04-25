using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiny : MonoBehaviour {

	private bool shinyDown;
	public float shinyMoveSpeed = 0.13f;
	public float moveThreshold = 0.1f; 
	float initPosY;

	void Start()
	{

		initPosY = transform.position.y; 
		int randomNum = Random.Range (0, 10); 

		if (randomNum > 5) {
			shinyDown = true; 
		} else {
			shinyDown = false; 
		}

	}

	void Update()
	{
		if(shinyDown) 
			transform.Translate (Vector2.down * shinyMoveSpeed * Time.deltaTime); 
		else 
			transform.Translate (-Vector2.down * shinyMoveSpeed * Time.deltaTime); 

		if (transform.position.y >= initPosY + moveThreshold)
		{
			shinyDown = true;
		}

		if (transform.position.y <= initPosY - moveThreshold)
		{
			shinyDown = false; 
		}
	}
}