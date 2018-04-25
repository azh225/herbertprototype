using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {

	private AudioSource backgroundMusic;

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad(transform.gameObject);
		backgroundMusic = GetComponent<AudioSource>();
	}

	public void PlayMusic()
	{
		if (backgroundMusic.isPlaying) return;
		backgroundMusic.Play();
	}

	public void StopMusic()
	{
		backgroundMusic.Stop();
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
