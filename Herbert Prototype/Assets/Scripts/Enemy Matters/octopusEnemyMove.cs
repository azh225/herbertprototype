using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class octopusEnemyMove : MonoBehaviour {

	private bool octoRight = true; 
	private bool octoDown = true;
	public float octoMoveSpeed = 2.0f; 
	public float moveThresholdX = 5f; 
	public float moveThresholdY = 2f; 
	float initPosX;
	float initPosY;

	public AudioClip shellSound;
	public AudioClip hitSound; 
	public AudioSource audioSource;

	public ParticleSystem blood; 

	// Use this for initialization
	void Start () 
	{
		initPosX = transform.position.x; 
		initPosY = transform.position.y; 
		int randomNum = Random.Range (0, 10); 

		if (randomNum > 5) {
			octoRight = true;
			octoDown = false; 
		} 

		else 
		{
			octoRight = false;
			octoDown = true;
		}

		audioSource = GetComponent<AudioSource> (); 

	}
	
	// Update is called once per frame
	void Update () {
		if (octoRight) 
			transform.Translate (Vector2.right * octoMoveSpeed * Time.deltaTime); 
		else
			transform.Translate (-Vector2.right * octoMoveSpeed * Time.deltaTime); 


		if (transform.position.x >= initPosX + moveThresholdX)
		{
			octoRight = false;
		}

		if (transform.position.x <= initPosX - moveThresholdX)
		{
			octoRight = true; 
		}


		if(octoDown) 
			transform.Translate (Vector2.down * octoMoveSpeed * Time.deltaTime); 
		else 
			transform.Translate (-Vector2.down * octoMoveSpeed * Time.deltaTime); 

		if (transform.position.y >= initPosY + moveThresholdY)
		{
			octoDown = true;
		}

		if (transform.position.y <= initPosY - moveThresholdY)
		{
			octoDown = false; 
		}
	}

	void OnTriggerEnter2D (Collider2D herbert) 
	{

		if (herbert.gameObject.tag == "Player") 
		{
			audioSource.PlayOneShot (hitSound, 1.0f); 
			herbert.gameObject.GetComponent<playerMovement> ().num_of_lives = herbert.gameObject.GetComponent<playerMovement> ().num_of_lives - 2;  
			blood.Play(); 
		}

		if (herbert.gameObject.tag == "Shell") 
		{
			audioSource.PlayOneShot (shellSound, 1.0f); 
			herbert.gameObject.GetComponent<playerMovement> ().num_of_lives--; 
		}


		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_lives < 1) 
		{
			SceneManager.LoadScene ("LevelFail"); 
		}
			
	}
}
