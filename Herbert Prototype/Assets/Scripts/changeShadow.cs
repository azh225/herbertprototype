using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeShadow : MonoBehaviour {

	public SpriteRenderer shadowSR; 
	public SpriteRenderer shadow2SR; 
	public SpriteRenderer shadow3SR; 


	// Use this for initialization
	void Start () 
	{
		shadowSR = GetComponent<SpriteRenderer>();  
		shadow2SR = GetComponent<SpriteRenderer>();  
		shadow3SR = GetComponent<SpriteRenderer>();  
	}
	
	// Update is called once per frame
	void Update () 
	{
  
	}
		
}
