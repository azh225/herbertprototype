using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coralSounds : MonoBehaviour {

	public AudioClip coralSound;

	// Use this for initialization
	void Start () {

		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = coralSound; 

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D other)
	{ 
		if (other.gameObject.tag == "Player") 
		{ 
			GetComponent<AudioSource> ().Play ();
		}
	}
}
