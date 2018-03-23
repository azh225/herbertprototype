using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMove : MonoBehaviour {

	private bool coralDown;
	public float coralMoveSpeed;
	public float moveThreshold; 
	float initPosY;

	void Start()
	{
		//sr = GetComponent<SpriteRenderer>();  

		initPosY = transform.position.y; 
		int randomNum = Random.Range (0, 10); 

		if (randomNum > 5) {
			coralDown = true; 
		} else {
			coralDown = false; 
		}

	}

	void Update()
	{
		if (gameObject.tag == "Coral") {
			UpDownCoral (); 
		}

		if (gameObject.tag == "Left") {
			LeftRightCoral (); 
		}
		
	}

	void UpDownCoral() {
		
		if(coralDown) 
			transform.Translate (Vector2.down * coralMoveSpeed * Time.deltaTime); 
		else 
			transform.Translate (-Vector2.down * coralMoveSpeed * Time.deltaTime); 

		if (transform.position.y >= initPosY + moveThreshold)
		{
			coralDown = true;
		}

		if (transform.position.y <= initPosY - moveThreshold)
		{
			coralDown = false; 
		}
	}

	void LeftRightCoral() {

	}

}