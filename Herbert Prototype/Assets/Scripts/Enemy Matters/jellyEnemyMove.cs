using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class jellyEnemyMove : MonoBehaviour {


	private bool jellyDown;
	public float jellyMoveSpeed = 5f;
	public float moveThreshold = 2f; 
	float initPosY; 

	public AudioClip shellSound;
	public AudioClip hitSound; 
	public AudioSource audioSource; 

	public ParticleSystem blood; 

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

		audioSource = GetComponent<AudioSource> (); 

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