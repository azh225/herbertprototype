using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class urchinEnemy : MonoBehaviour {

	public AudioClip shellSound;
	public AudioClip hitSound; 
	public AudioSource audioSource; 

	public ParticleSystem blood; 

	// Use this for initialization
	void Start () 
	{
		audioSource = GetComponent<AudioSource> (); 
	}
	
	// Update is called once per frame
	void Update () {

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
	