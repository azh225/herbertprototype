using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class shinyCollect : MonoBehaviour {

	public Sprite[] ShinyBarSprite;  
	public Image ShinyBarUI; 

	public GameObject shiny1; 
	public GameObject shiny2;
	public GameObject shiny3; 
	//private playerMovement herbert; 

	// Use this for initialization
	void Start () {
		//herbert = GameObject.FindGameObjectWithTag ("Player").GetComponent<playerMovement>(); 
	}
	
	// Update is called once per frame
	void Update () {

		if (shiny1 && shiny2 && shiny3)
		{
			ShinyBarUI.sprite = ShinyBarSprite[0];  
		}

		else if (shiny1 && shiny2)
		{
			ShinyBarUI.sprite = ShinyBarSprite[4];  
		}

		else if (shiny1 && shiny3)
		{
			ShinyBarUI.sprite = ShinyBarSprite[3];  
		}

		else if (shiny2 && shiny3)
		{
			ShinyBarUI.sprite = ShinyBarSprite[2];  
		}

		else if (shiny1)
		{
			ShinyBarUI.sprite = ShinyBarSprite[6];  
		}

		else if (shiny2)
		{
			ShinyBarUI.sprite = ShinyBarSprite[7];  
		}

		else if (shiny3) 
		{
			ShinyBarUI.sprite = ShinyBarSprite [5];  
		} 

		else 
		{
			ShinyBarUI.sprite = ShinyBarSprite [1]; 
		}
	}
}
