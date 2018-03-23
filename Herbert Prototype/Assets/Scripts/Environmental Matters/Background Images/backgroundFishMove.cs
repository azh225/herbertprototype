using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundFishMove : MonoBehaviour {

	private bool fishRight; 
	public float fishMoveSpeed; 
	public float moveThreshold; 
	float initPosX; 

	public SpriteRenderer fsr;  


	// Use this for initialization
	void Start () {

		initPosX = transform.position.x; 
		int randomNum = Random.Range (0, 10); 

		if (randomNum > 5) {
			fishRight = true; 
		} else {
			fishRight = false; 
		}

		fsr = GetComponent<SpriteRenderer>(); 

		
	}
	
	// Update is called once per frame
	void Update () {

		if (fishRight)
		{
			transform.Translate (Vector2.right * fishMoveSpeed * Time.deltaTime);
			fsr.flipX = true; 
		}

		else 
		{
			transform.Translate (-Vector2.right * fishMoveSpeed * Time.deltaTime); 
			fsr.flipX = false; 

		}

		if (transform.position.x >= initPosX + moveThreshold)
		{
			fishRight = false;
		}
			

		if (transform.position.x <= initPosX - moveThreshold)
		{
			fishRight = true;
		}

		
	}
}
