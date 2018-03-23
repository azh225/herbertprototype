using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiny : MonoBehaviour {

//	public Sprite coin; 
//	public Sprite shadow; 
//	public SpriteRenderer sr; 
//	public GameObject shinyShadow1; 
//	public GameObject shinyShadow2; 
//	public GameObject shinyShadow3; 

	private bool shinyDown;
	public float shinyMoveSpeed = 0.13f;
	public float moveThreshold = 0.1f; 
	float initPosY;

	void Start()
	{
		//sr = GetComponent<SpriteRenderer>();  

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




	/*
	void OnCollisionEnter2D (Collision2D herbert)
	{ 
		if (herbert.gameObject.tag == "Player" || herbert.gameObject.tag == "Attack") 
		{ 
			herbert.gameObject.GetComponent<playerMovement> ().num_of_shinnies++; 
			Destroy (gameObject);
			Debug.Log ("I have this many coins: " + herbert.gameObject.GetComponent<playerMovement> ().num_of_shinnies); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_shinnies == 9) 
		{
			//imageChange1 (); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_shinnies == 18) 
		{
			//imageChange2 (); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_shinnies == 27 || herbert.gameObject.GetComponent<playerMovement> ().num_of_shinnies == 12) 
		{
			//imageChange3 (); 
			Destroy (GameObject.FindGameObjectWithTag ("Bubble Wall 2"));

		}

	} */

//	public void imageChange1()
//	{
//		shinyShadow1.gameObject.GetComponent<changeShadow> ().shadowSR.sprite = coin;  
//	}
//
//	public void imageChange2()
//	{
//		shinyShadow2.gameObject.GetComponent<changeShadow> ().shadow2SR.sprite = coin;  
//	}
//
//	public void imageChange3()
//	{
//		shinyShadow3.gameObject.GetComponent<changeShadow> ().shadow3SR.sprite = coin;  
//	}
//
//	public void imageNotChange()
//	{
//		sr.sprite = shadow; 
//	}
		
}