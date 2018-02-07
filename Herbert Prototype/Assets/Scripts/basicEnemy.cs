using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class basicEnemy : MonoBehaviour {

	private bool crabRight = true; 
	float crabMoveSpeed = 2.0f; 

	public float num_of_lives = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//crab movement 
		if (crabRight) {
			transform.Translate (Vector2.right * crabMoveSpeed * Time.deltaTime);
		} 

		else 
		{
			transform.Translate (-Vector2.right * crabMoveSpeed * Time.deltaTime); 
		}


		if (transform.position.x > 46.8f) {
			crabRight = false;
		}

		if (transform.position.x < 35.5f) {
			crabRight = true; 
		}
			

	}

	void OnTriggerEnter2D (Collider2D herbert) 
	{
		if (herbert.gameObject.tag == "Player") {
			num_of_lives = num_of_lives - 1; 
			Debug.Log ("one less life");  

		}

		if (num_of_lives == 2)
		{
			Destroy (GameObject.FindGameObjectWithTag ("Life 3")); 

		}

		if (num_of_lives == 1)
		{
			Destroy (GameObject.FindGameObjectWithTag ("Life 2")); 

		}

		if (num_of_lives < 1) {
			Destroy (GameObject.FindGameObjectWithTag ("Life"));
			Destroy (GameObject.FindGameObjectWithTag ("Player")); 
			SceneManager.LoadScene ("LevelFail"); 
		}


	}
}
