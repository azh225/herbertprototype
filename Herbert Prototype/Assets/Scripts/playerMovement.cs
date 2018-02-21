using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

	public Sprite hermitShell; 
	public Sprite dangerHermit; 
	public Sprite herbert; 
	public SpriteRenderer sr;  


	void Start ()
	{
		sr = GetComponent<SpriteRenderer>(); 

		num_of_shinnies = 0; 

		hrb2D = GetComponent<Rigidbody2D>();
		myTrans = this.transform; 
		tagGround = GameObject.Find (this.name + "/tag_ground").transform;  
	}


	void FixedUpdate ()
	{
		if (Input.GetKeyDown (KeyCode.Z)) 
			imageDefense ();
		
		if (Input.GetKeyDown (KeyCode.X)) 
			imageAttack (); 

		if (Input.GetKeyDown (KeyCode.DownArrow)) 
			Destroy (GameObject.FindGameObjectWithTag ("DigGround")); 
	
		if (Input.GetKeyUp (KeyCode.Z))  
			imageOriginal ();
		
		if (Input.GetKeyUp (KeyCode.X)) 
			imageOriginal ();
		

		isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);   

		Move(Input.GetAxis("Horizontal"));  
		if (Input.GetKeyDown (KeyCode.UpArrow)) //"Jump" using Edit --> Project Settings --> Input. Change space for up
			Jump(); 
		

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

	public void imageAttack()
	{
		sr.sprite = dangerHermit; 
		tag = "Attack"; 
		isHidingActive = false; 
	}

	public void imageOriginal()
	{
		sr.sprite = herbert; 
		tag = "Player"; 
		isHidingActive = false; 
	}

//	void OnCollisionEnter2D (Collision2D sand) 
//	{
//		if (sand.gameObject.tag == "DigGround" && Input.GetKeyDown (KeyCode.DownArrow))
//		{
//			//if (Input.GetKeyDown (KeyCode.DownArrow))
//				Destroy (GameObject.FindGameObjectWithTag ("DigGround")); 
//		}

	//}

}
	