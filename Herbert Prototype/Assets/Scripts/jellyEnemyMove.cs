using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class jellyEnemyMove : MonoBehaviour {


	private bool jellyDown;// = true; 
	float jellyMoveSpeed = 1.75f; 
	public float num_of_lives = 3;

	// Use this for initialization
	void Start () 
	{
		
	}


	// Update is called once per frame
	void Update ()
	{
		if(jellyDown) 
		{
			transform.Translate (Vector2.down * jellyMoveSpeed * Time.deltaTime);
		} 

		else 
		{
			transform.Translate (-Vector2.down * jellyMoveSpeed * Time.deltaTime); 
		}

		if (transform.position.y >= 1.3f)
		{
			jellyDown = true;
		}

		if (transform.position.y <= -4.6f) 
		{
			jellyDown = false; 
		}

	}


	void OnTriggerEnter2D (Collider2D herbert)
	{
		if (herbert.gameObject.tag == "Player") {
			num_of_lives = num_of_lives - 1; 
			Debug.Log ("one less life");  

		}

		if (num_of_lives == 2) {
			Destroy (GameObject.FindGameObjectWithTag ("Life 3")); 

		}

		if (num_of_lives == 1) {
			Destroy (GameObject.FindGameObjectWithTag ("Life 2")); 

		}

		if (num_of_lives < 1) {
			Destroy (GameObject.FindGameObjectWithTag ("Life"));
			Destroy (GameObject.FindGameObjectWithTag ("Player")); 
			SceneManager.LoadScene ("LevelFail"); 
		}
	}

}
