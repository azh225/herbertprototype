using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement: MonoBehaviour
{

	public bool canMove; 
	float moveSpeed = 10f; 
	float jumpSpeed = 80f; 

	public Rigidbody2D rb2D; 

	public BoxCollider2D herbertCollider;
	public GameObject herbert;

	// Use this for initialization
	void Start () 
	{
		rb2D = GetComponent<Rigidbody2D> (); 
		canMove = true; 
		 

	}

	private void Move(float dx, float dy)
	{
		rb2D.velocity = new Vector2 (dx * moveSpeed, dy * jumpSpeed); 
	}
	
	// Update is called once per frame
	void Update () {

		//float x = Input.GetAxis("Horizontal"); 
		//float y = Input.GetAxis("Vertical"); 

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Translate (Vector2.left * moveSpeed * Time.deltaTime);
		} 

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Translate (Vector2.right * moveSpeed * Time.deltaTime);
		} 


		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			transform.Translate (Vector2.up * jumpSpeed * Time.deltaTime);
		}
			
	}
}
