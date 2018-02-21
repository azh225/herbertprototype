using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuttleSTOPColliderTrigger : MonoBehaviour {
	public GameObject cuttlefish; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D (Collider2D herbert) 
	{

		if (herbert.gameObject.tag == "Player" || herbert.gameObject.tag == "Attack") 
		{ 
			cuttlefish.gameObject.GetComponent<cuttlefishEnemyMove> ().moveThreshold = 0;
			cuttlefish.gameObject.GetComponent<cuttlefishEnemyMove> ().cuttleMoveSpeed = 0; 
		}

	}
}
