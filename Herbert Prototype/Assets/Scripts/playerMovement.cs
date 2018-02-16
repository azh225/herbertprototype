using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
 
	public bool isGrounded = false;
	public bool isHiding = false; 
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
		if (Input.GetButtonDown("Jump")) 
			Jump(); 


	}

	public void Move(float horizontalInput) 
	{
		if (isHiding)
			return; 
		
		Vector2 moveVel = hrb2D.velocity; 
		moveVel.x = horizontalInput * moveSpeed; 
		hrb2D.velocity = moveVel; 
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
		isHiding = true; 
	}

	public void imageAttack()
	{
		sr.sprite = dangerHermit; 
		tag = "Attack"; 
		isHiding = false; 
	}

	public void imageOriginal()
	{
		sr.sprite = herbert; 
		tag = "Player"; 
		isHiding = false; 
	}

}


//don't use canMove anymore-- still want to impliment toggle movement for defense
////		//  If we press '0' on the keyboard we toggle movement.
////		if(Input.GetKeyDown(KeyCode.Alpha0))
////		{
////			canMove = !canMove;
////		}


/*			shield = new List<Shield> (); 

for (int i = 0; i < 1; i++)
{
	Shield b = new Shield (); 
	b.shieldObject = Instantiate (shieldPrefab); 
	b.shieldObject.transform.position = tagShieldSpawn.position; 
 
}
*/ 