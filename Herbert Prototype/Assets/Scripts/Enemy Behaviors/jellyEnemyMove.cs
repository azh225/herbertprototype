using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class jellyEnemyMove : MonoBehaviour {


	private bool jellyDown;
	public float jellyMoveSpeed = 5f;
	public float moveThreshold = 2f; 
	float initPosY; 



	// Use this for initialization
	void Start () 
	{
		initPosY = transform.position.y; 
		int randomNum = Random.Range (0, 10); 

		if (randomNum > 5) {
			jellyDown = true; 
		} else {
			jellyDown = false; 
		}
	}


	// Update is called once per frame
	void Update ()
	{
		if(jellyDown) 
			transform.Translate (Vector2.down * jellyMoveSpeed * Time.deltaTime); 
		else 
			transform.Translate (-Vector2.down * jellyMoveSpeed * Time.deltaTime); 

		if (transform.position.y >= initPosY + moveThreshold)
		{
			jellyDown = true;
		}

		if (transform.position.y <= initPosY - moveThreshold)
		{
			jellyDown = false; 
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

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_lives < 1) 
		{
//			Destroy (GameObject.FindGameObjectWithTag ("Life 8")); 
//			Destroy (GameObject.FindGameObjectWithTag ("Life 7")); 
//			Destroy (GameObject.FindGameObjectWithTag ("Life 6")); 
//			Destroy (GameObject.FindGameObjectWithTag ("Life 5")); 
//			Destroy (GameObject.FindGameObjectWithTag ("Life 4")); 
//			Destroy (GameObject.FindGameObjectWithTag ("Life 3")); 
//			Destroy (GameObject.FindGameObjectWithTag ("Life 2")); 
//			Destroy (GameObject.FindGameObjectWithTag ("Life 1"));
//			Destroy (GameObject.FindGameObjectWithTag ("Player")); 
			SceneManager.LoadScene ("LevelFail"); 
		}
	}

}

/* 
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

*/ 
