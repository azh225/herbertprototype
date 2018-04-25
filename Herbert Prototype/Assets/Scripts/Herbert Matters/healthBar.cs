using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class healthBar : MonoBehaviour {

	public Sprite[] HeartSprites;  
	public Image HeartUI; 
	private playerMovement herbert; 

	// Use this for initialization
	void Start () {
		herbert = GameObject.FindGameObjectWithTag ("Player").GetComponent<playerMovement>(); 
	}
	
	// Update is called once per frame
	void Update () {
		HeartUI.sprite = HeartSprites[herbert.num_of_lives];  
	}
}
