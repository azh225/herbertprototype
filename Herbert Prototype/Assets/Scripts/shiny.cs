using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiny : MonoBehaviour {

	public float num_of_shinnies;

	void Start()
	{

	}

	void Update()
	{

	}

	void OnCollisionEnter2D (Collision2D herbert)
	{ 
		if (herbert.gameObject.tag == "Player") 
		{
			num_of_shinnies = num_of_shinnies + 1; 
			Debug.Log ("I have " + num_of_shinnies);

			if (num_of_shinnies == 1) 
			{
				Destroy (GameObject.FindGameObjectWithTag ("Shiny 1")); 
			}

			if (num_of_shinnies == 2) 
			{
				Destroy (GameObject.FindGameObjectWithTag ("Shiny 2")); 
			}

			if (num_of_shinnies == 3) 
			{
				Destroy (GameObject.FindGameObjectWithTag ("Shiny 3")); 
			}

		}

//		if (herbert.gameObject.tag == "Player")
//		{
//			num_of_shinnies = 2;  
//			Debug.Log ("I have " + num_of_shinnies);
//			Destroy (GameObject.FindGameObjectWithTag ("Shiny 2")); 
//		}
//
//		if (herbert.gameObject.tag == "Player") 
//		{
//			num_of_shinnies = 3;  
//			Debug.Log ("I have " + num_of_shinnies);
//			Destroy (GameObject.FindGameObjectWithTag ("Shiny 3"));
//		}

		if (num_of_shinnies == 3) 
		{
			Debug.Log ("Have 3 Shinnies"); 
			Destroy (GameObject.FindGameObjectWithTag ("Bubble Wall 2")); 
		}




	}
}