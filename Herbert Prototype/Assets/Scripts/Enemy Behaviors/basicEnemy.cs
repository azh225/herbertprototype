using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class basicEnemy : MonoBehaviour {

	private bool crabRight; 
	public float crabMoveSpeed = 5.0f; 
	public float moveThreshold = 5.5f; 
	float initPosX; 

	// Use this for initialization
	void Start () {
		initPosX = transform.position.x; 
		int randomNum = Random.Range (0, 10); 

		if (randomNum > 5) {
			crabRight = true; 
		} else {
			crabRight = false; 
		}
	}

	
	// Update is called once per frame
	void Update () {

		//crab movement 

		if (crabRight) 
			transform.Translate (Vector2.right * crabMoveSpeed * Time.deltaTime); 
		else
			transform.Translate (-Vector2.right * crabMoveSpeed * Time.deltaTime); 


		if (transform.position.x >= initPosX + moveThreshold)
		{
			crabRight = false;
		}

		if (transform.position.x <= initPosX - moveThreshold)
		{
			crabRight = true; 
		}
			
	}

	void OnTriggerEnter2D (Collider2D herbert) 
	{

		if (herbert.gameObject.tag == "Attack") 
		{
			Debug.Log ("danger hermit is hitting enemy"); 
			Destroy (this.gameObject); 
		}

		if (herbert.gameObject.tag == "Player") 
		{
			herbert.gameObject.GetComponent<playerMovement> ().num_of_lives = herbert.gameObject.GetComponent<playerMovement> ().num_of_lives - 2; 
		}

		if (herbert.gameObject.tag == "Shell")
		{
			herbert.gameObject.GetComponent<playerMovement> ().num_of_lives--; 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_lives == 7) 
		{
			Debug.Log ("I have this many lives: " + herbert.gameObject.GetComponent<playerMovement> ().num_of_lives); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 8")); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_lives == 6)
		{
			Debug.Log ("I have this many lives: " + herbert.gameObject.GetComponent<playerMovement> ().num_of_lives);
			Destroy (GameObject.FindGameObjectWithTag ("Life 8")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 7")); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_lives == 5)
		{
			Debug.Log ("I have this many lives: " + herbert.gameObject.GetComponent<playerMovement> ().num_of_lives);
			Destroy (GameObject.FindGameObjectWithTag ("Life 8")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 7")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 6")); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_lives == 4)
		{
			Debug.Log ("I have this many lives: " + herbert.gameObject.GetComponent<playerMovement> ().num_of_lives);
			Destroy (GameObject.FindGameObjectWithTag ("Life 8")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 7")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 6")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 5")); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_lives == 3)
		{
			Debug.Log ("I have this many lives: " + herbert.gameObject.GetComponent<playerMovement> ().num_of_lives);
			Destroy (GameObject.FindGameObjectWithTag ("Life 8")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 7")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 6")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 5")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 4")); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_lives == 2)
		{
			Debug.Log ("I have this many lives: " + herbert.gameObject.GetComponent<playerMovement> ().num_of_lives);
			Destroy (GameObject.FindGameObjectWithTag ("Life 8")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 7")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 6")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 5")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 4")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 3")); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_lives == 1)
		{
			Debug.Log ("I have this many lives: " + herbert.gameObject.GetComponent<playerMovement> ().num_of_lives);
			Destroy (GameObject.FindGameObjectWithTag ("Life 8")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 7")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 6")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 5")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 4")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 3")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 2")); 
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_lives < 1) 
		{
			Destroy (GameObject.FindGameObjectWithTag ("Life 8")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 7")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 6")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 5")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 4")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 3")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 2")); 
			Destroy (GameObject.FindGameObjectWithTag ("Life 1"));
			Destroy (GameObject.FindGameObjectWithTag ("Player")); 
			SceneManager.LoadScene ("LevelFail"); 
		}


	}
}
