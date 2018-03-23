using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundRay : MonoBehaviour {

	private bool rayRight = true; 
	private bool rayDown = true;
	public float rayMoveSpeed; 
	public float moveThresholdX; 
	public float moveThresholdY; 
	float initPosX;
	float initPosY;

	public SpriteRenderer rsr;  


	// Use this for initialization
	void Start () {
		
		initPosX = transform.position.x; 
		initPosY = transform.position.y; 
		int randomNum = Random.Range (0, 10); 

		if (randomNum > 5) {
			rayRight = true;
			rayDown = false; 
		} 

		else 
		{
			rayRight = false;
			rayDown = true;
		}

		rsr = GetComponent<SpriteRenderer>(); 


	}
	
	// Update is called once per frame
	void Update () {
		if (rayRight) {
			transform.Translate (Vector2.right * rayMoveSpeed * Time.deltaTime);
			rsr.flipX = false; 

		} 

		else 
		{
			transform.Translate (-Vector2.right * rayMoveSpeed * Time.deltaTime);
			rsr.flipX = true; 

		}


		if (transform.position.x >= initPosX + moveThresholdX)
		{
			rayRight = false;
		}

		if (transform.position.x <= initPosX - moveThresholdX)
		{
			rayRight = true; 
		}


		if (rayDown) 
		{
			transform.Translate (Vector2.down * rayMoveSpeed * Time.deltaTime); 
			rsr.flipY = true; 
		} 

		else 
		{
			transform.Translate (-Vector2.down * rayMoveSpeed * Time.deltaTime); 
			rsr.flipY = false; 
		}

		if (transform.position.y >= initPosY + moveThresholdY)
		{
			rayDown = true;
		}

		if (transform.position.y <= initPosY - moveThresholdY)
		{
			rayDown = false; 
		}
	}
}
