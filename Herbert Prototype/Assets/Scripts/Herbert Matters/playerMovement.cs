using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class playerMovement : MonoBehaviour
{
 
	public bool isGrounded = false;
	public bool isHidingActive = false; 
	public LayerMask playerMask; 
	public float moveSpeed = 10f;
	public float jumpSpeed = 20f;
	public bool isMoving = false; 
	Transform myTrans;  
	Transform tagGround;
	public Rigidbody2D hrb2D;

	public int num_of_shinnies; 
	public int num_of_lives = 8;

	public Sprite hermitShell; 
	public Sprite herbert; 
	public SpriteRenderer sr;   

	public AudioClip shinySound;
	public AudioClip coralLandingSound;
	public AudioClip sandLandingSound;
	public AudioSource audioSource; 

	public Animator anim; 


	void Start ()
	{
		sr = GetComponent<SpriteRenderer>(); 
		anim = GetComponent<Animator> (); 

		hrb2D = GetComponent<Rigidbody2D>();
		myTrans = this.transform; 
		tagGround = GameObject.Find (this.name + "/tag_ground").transform;  

		num_of_shinnies = 0;
		audioSource = GetComponent<AudioSource> (); 

	}


	void FixedUpdate ()
	{

		if (num_of_shinnies == 3) 
		{
			Destroy (GameObject.FindGameObjectWithTag ("Bubble Wall 2"));
		}
			

		if (Input.GetKeyDown (KeyCode.Z)) 
			imageDefense ();
 
	
		if (Input.GetKeyUp (KeyCode.Z))  
			imageOriginal ();
		

		isGrounded = Physics2D.Linecast (myTrans.position, tagGround.position, playerMask);   

		Move(Input.GetAxis("Horizontal"));  
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			Jump (); 
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			sr.flipX = true;

			 
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			sr.flipX = false; 
			 
		}

	}

	public void Move(float horizontalInput) 
	{
		anim.SetFloat ("moveX", Mathf.Abs(horizontalInput)); 

		if (isHidingActive == true) 
		{
			anim.SetBool ("hiding", true); 
			Vector2 moveVel = hrb2D.velocity;  
			moveVel.x = horizontalInput * 0;  
			hrb2D.velocity = moveVel; 
		}

		if (isHidingActive == false) 
		{
			anim.SetBool ("hiding", false); 
			Vector2 moveVel = hrb2D.velocity; 
			moveVel.x = horizontalInput * moveSpeed; 
			hrb2D.velocity = moveVel; 
		}
	}

	public void Jump()
	{
		if(isGrounded)  
			hrb2D.velocity += jumpSpeed * Vector2.up;
	}

	public void imageDefense() 
	{
		sr.sprite = hermitShell;
		tag = "Shell"; 
		isHidingActive = true; 
	}
		
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
			audioSource.PlayOneShot (shinySound, 1.0f); 
			num_of_shinnies++; 
			Destroy (other.gameObject);
		}
	}

	void OnCollisionEnter2D (Collision2D other) 
	{
		if (other.gameObject.tag == "Ground") 
		{ 
			audioSource.PlayOneShot (sandLandingSound, 0.2f); 
		}


		if (other.gameObject.tag == "Coral") 
		{ 
			audioSource.PlayOneShot (coralLandingSound, 0.06f); 
		}
	}


}
	