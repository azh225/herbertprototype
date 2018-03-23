using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMoveInstructions : MonoBehaviour {

	public GameObject upPrefab; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D herbert)
	{
		Destroy (transform.parent.gameObject); 
		Instantiate (upPrefab); 
	}
}
