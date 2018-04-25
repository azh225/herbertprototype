using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createArrows : MonoBehaviour {

	public GameObject leftArrowAbove;
	public GameObject leftArrowUnder;
	public GameObject UpArrowUnder;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D herbert)
	{
		Instantiate (leftArrowAbove);
		Instantiate (leftArrowUnder); 
		Instantiate (UpArrowUnder); 
	}

}
