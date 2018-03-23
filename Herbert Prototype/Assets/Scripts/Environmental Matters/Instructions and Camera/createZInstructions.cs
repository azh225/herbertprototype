using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createZInstructions : MonoBehaviour {

	public GameObject ZPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D (Collider2D herbert)
	{
		Instantiate (ZPrefab);
		Destroy (this.gameObject); 
	}
}
