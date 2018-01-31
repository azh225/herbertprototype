using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiny : MonoBehaviour {

	Score score; 

	// Use this for initialization
	void Start () {
		score = GameObject.Find ("Text").GetComponent<Score> ();
	}

	// Update is called once per frame
	void Update () {
	}
		
	void OnCollisionEnter2D(Collision2D other) {
			Destroy (transform.gameObject);
			Debug.Log ("DESTROY MYSELF!!!");
			Score.score++; 

	}
}
