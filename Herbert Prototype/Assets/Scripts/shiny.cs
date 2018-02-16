using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiny : MonoBehaviour {

	public Sprite coin; 
	public Sprite shadow; 
	public SpriteRenderer sr; 

	void Start()
	{
		sr = GetComponent<SpriteRenderer>();  

	}

	void Update()
	{

	}

	void OnCollisionEnter2D (Collision2D herbert)
	{ 
		if (herbert.gameObject.tag == "Player") 
		{
			herbert.gameObject.GetComponent<playerMovement> ().num_of_shinnies++; 
			Destroy (gameObject);  
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_shinnies == 2) 
		{
			Debug.Log ("Have 2 Shinnies"); 
			//imageChange (GameObject.FindGameObjectWithTag ("shinyShadow1"));
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_shinnies == 3) 
		{
			Debug.Log ("Have 3 Shinnies"); 
			Destroy (GameObject.FindGameObjectWithTag ("Bubble Wall 2")); 
		}

	}

	public void imageChange()
	{
		sr.sprite = coin;  
	}

	public void imageNotChange()
	{
		sr.sprite = shadow; 
	}
		
}