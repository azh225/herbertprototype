using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class playerMovement : MonoBehaviour
{
 
	public bool isGrounded = false;
	public bool isHidingActive = false; 
	public LayerMask playerMask; 
	public float moveSpeed = 15f;
	public float jumpSpeed = 20f; 
	Transform myTrans;  
	Transform tagGround;
	Rigidbody2D hrb2D;

	public int num_of_shinnies; 
	public float num_of_lives = 8;
	public Text livesText; 
	public Text scoreText; 

	public Sprite hermitShell; 
	//public Sprite dangerHermit; 
	public Sprite herbert; 
	public SpriteRenderer sr;  


	void Start ()
	{
		sr = GetComponent<SpriteRenderer>(); 

		num_of_shinnies = 0; 

		livesText.text = "Lives: " + num_of_lives;  

		hrb2D = GetComponent<Rigidbody2D>();
		myTrans = this.transform; 
		tagGround = GameObject.Find (this.name + "/tag_ground").transform;  
	}


	void FixedUpdate ()
	{
		if (num_of_lives == 7) {
			livesText.text = "Lives: " + 7;   
		}
		if (num_of_lives == 6) {
			livesText.text = "Lives: " + 6;   
		}
		if (num_of_lives == 5) {
			livesText.text = "Lives: " + 5;   
		}
		if (num_of_lives == 4) {
			livesText.text = "Lives: " + 4;   
		}
		if (num_of_lives == 3) {
			livesText.text = "Lives: " + 3;   
		}
		if (num_of_lives == 2) {
			livesText.text = "Lives: " + 2;   
		}
		if (num_of_lives == 1) {
			livesText.text = "Lives: " + 1;   
		}

		if (num_of_shinnies == 1) 
		{
			scoreText.text = "Shinies: " + 1; 
		}

		if (num_of_shinnies == 2) 
		{
			scoreText.text = "Shinies: " + 2; 
			//Destroy (GameObject.FindGameObjectWithTag ("DigGround"));

		}

		if (num_of_shinnies == 3) 
		{
			scoreText.text = "Shinies: " + 3; 
			Destroy (GameObject.FindGameObjectWithTag ("Bubble Wall 2"));

		}



		if (Input.GetKeyDown (KeyCode.Z)) 
			imageDefense ();
		
//		if (Input.GetKeyDown (KeyCode.X)) 
//			imageAttack (); 
//
//		if (Input.GetKeyDown (KeyCode.DownArrow)) 
//			Destroy (GameObject.FindGameObjectWithTag ("DigGround")); 
	
		if (Input.GetKeyUp (KeyCode.Z))  
			imageOriginal ();
		
//		if (Input.GetKeyUp (KeyCode.X)) 
//			imageOriginal ();
//		

		isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);   

		Move(Input.GetAxis("Horizontal"));  
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Jump (); 
		}
		

	}

	public void Move(float horizontalInput) 
	{
		if (isHidingActive == true) 
		{
			Vector2 moveVel = hrb2D.velocity;  
			moveVel.x = horizontalInput * 0;  
			hrb2D.velocity = moveVel; 
		}

		if (isHidingActive == false) 
		{
			Vector2 moveVel = hrb2D.velocity; 
			moveVel.x = horizontalInput * moveSpeed; 
			hrb2D.velocity = moveVel; 
		}
	}

	public void Jump()
	{
		if(isGrounded && isHidingActive == false)  
			hrb2D.velocity += jumpSpeed * Vector2.up;
	}

	public void imageDefense() 
	{
		sr.sprite = hermitShell;
		tag = "Shell"; 
		isHidingActive = true; 
	}
//
//	public void imageAttack()
//	{
//		sr.sprite = dangerHermit; 
//		tag = "Attack"; 
//		isHidingActive = false; 
//	}

	public void imageOriginal()
	{
		sr.sprite = herbert; 
		tag = "Player"; 
		isHidingActive = false; 
	}
		

	void OnTriggerEnter2D (Collider2D other)
	{ 
		if (other.gameObject.tag == "Coin") 
		{ 
			num_of_shinnies++; 
			Destroy (other.gameObject);
			//Debug.Log ("I have this many coins: " + num_of_shinnies); 
		}

	}

}
	