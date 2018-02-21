using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiny : MonoBehaviour {

	public Sprite coin; 
	public Sprite shadow; 
	public SpriteRenderer sr; 
	public GameObject shinyShadow1; 
	public GameObject shinyShadow2; 
	public GameObject shinyShadow3; 

	void Start()
	{
		sr = GetComponent<SpriteRenderer>();  

	}

	void Update()
	{

	}

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
			imageChange1 (); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_shinnies == 18) 
		{
			imageChange2 (); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_shinnies == 27) 
		{
			imageChange3 (); 
			Destroy (GameObject.FindGameObjectWithTag ("Bubble Wall 2"));

		}

	}

	public void imageChange1()
	{
		shinyShadow1.gameObject.GetComponent<changeShadow> ().shadowSR.sprite = coin;  
	}

	public void imageChange2()
	{
		shinyShadow2.gameObject.GetComponent<changeShadow> ().shadow2SR.sprite = coin;  
	}

	public void imageChange3()
	{
		shinyShadow3.gameObject.GetComponent<changeShadow> ().shadow3SR.sprite = coin;  
	}

	public void imageNotChange()
	{
		sr.sprite = shadow; 
	}
		
}