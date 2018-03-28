using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyAway : MonoBehaviour {

	public float flySpeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D herbert) {

		if (herbert.gameObject.tag == "Player") 
		{
			herbert.gameObject.GetComponent<playerMovement> ().hrb2D.velocity += flySpeed * Vector2.up;
		}
	}
}
