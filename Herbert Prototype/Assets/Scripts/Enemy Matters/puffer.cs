using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class puffer : MonoBehaviour {

	public AudioClip shellSound;
	public AudioClip hitSound; 
	public AudioSource audioSource; 

	public ParticleSystem blood; 

	public Sprite meanPuffer; 
	public Sprite happyPuffer; 
	public SpriteRenderer puffSR;

	public GameObject exitWall; 

	public Transform startMarker;
	public Transform endMarker; 
	public float speed = 1.0F;
	float startTime;
	float journeyLength;

	// Use this for initialization
	void Start () 
	{
		startTime = Time.time;
		journeyLength = Vector3.Distance (startMarker.position, endMarker.position);


		audioSource = GetComponent<AudioSource> (); 
		puffSR = GetComponent<SpriteRenderer> (); 
	}

	// Update is called once per frame
	void Update () {

		if (exitWall) 
		{
			puffSR.sprite = meanPuffer; 
		}

		if (!exitWall) 
		{
			puffSR.sprite = happyPuffer; 
			float distCovered = (Time.time - startTime) * speed;
			float fracJourney = distCovered / journeyLength;


			transform.position = Vector3.Lerp (startMarker.position, endMarker.position, fracJourney);
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
