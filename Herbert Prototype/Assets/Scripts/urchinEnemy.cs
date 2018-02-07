using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class urchinEnemy : MonoBehaviour {

	public float num_of_lives = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
