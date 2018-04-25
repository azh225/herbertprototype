using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonHover : MonoBehaviour {

	public SpriteRenderer hoverButtonSR;
	public Sprite button; 
	public Sprite buttonHOVER; 

	// Use this for initialization
	void Start () {
		hoverButtonSR = GetComponent<SpriteRenderer>(); 

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver() {
		hoverButtonSR.sprite = buttonHOVER;
	}

	void OnMouseExit() {
		hoverButtonSR.sprite = button; 
	}
}
