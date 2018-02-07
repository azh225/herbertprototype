using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMoveInstructions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D herbert){
		Debug.Log ("I'm HITTING IT"); 
		Destroy (transform.gameObject); 
		Destroy (GameObject.FindGameObjectWithTag ("Left/Right Instructions")); 
	}
}
