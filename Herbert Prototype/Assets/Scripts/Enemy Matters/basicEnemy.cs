using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class basicEnemy : MonoBehaviour {

	private bool crabRight; 
	public float crabMoveSpeed = 5.0f; 
	public float moveThreshold = 5.5f; 
	float initPosX; 

	public AudioClip shellSound;
	public AudioClip hitSound; 
	public AudioSource audioSource;

	public ParticleSystem blood; 

	// Use this for initialization
	void Start () {
		initPosX = transform.position.x; 
		int randomNum = Random.Range (0, 10); 

		if (randomNum > 5) {
			crabRight = true; 
		} else {
			crabRight = false; 
		}
			
		audioSource = GetComponent<AudioSource> (); 

	}

	
	// Update is called once per frame
	void Update () { 

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


		if (herbert.gameObject.tag == "Player") 
		{
			audioSource.PlayOneShot (hitSound, 1.0f); 
			herbert.gameObject.GetComponent<playerMovement> ().num_of_lives = herbert.gameObject.GetComponent<playerMovement> ().num_of_lives - 2; 
			blood.Play(); 
			screenShake.shakeScreen = true; 
			screenShake.playOnce = true; 
			screenShake.shakeTimer = 0.5f; 
			screenShake.shakeAmount = 0.6f;
		}

		if (herbert.gameObject.tag == "Shell")
		{
			audioSource.PlayOneShot (shellSound, 1.0f); 
			herbert.gameObject.GetComponent<playerMovement> ().num_of_lives--;
			screenShake.shellShake = true; 
			screenShake.playOnce = true; 
			screenShake.shakeTimer = 0.5f;
			screenShake.shakeAmount = 0.2f;
		}

		if (herbert.gameObject.GetComponent<playerMovement> ().num_of_lives < 1) 
		{
			SceneManager.LoadScene ("LevelFail"); 
		}

	}
}
	