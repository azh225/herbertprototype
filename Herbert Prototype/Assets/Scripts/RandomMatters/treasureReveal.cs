using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureReveal : MonoBehaviour {

	public Sprite open; 
	public Sprite closed; 
	public SpriteRenderer chestSR;
	public SpriteRenderer Shia;

	// Use this for initialization
	void Start () {
		chestSR = GetComponent<SpriteRenderer>(); 

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseEnter() {
		chestSR.sprite = open; 
	}

	void OnMouseExit() {
		chestSR.sprite = closed; 
	}

	void OnMouseDown() {
		Shia.sortingOrder = 3; 
	}

	void OnMouseUp() {
		Shia.sortingOrder = 0; 
	}
}
