using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeShadow : MonoBehaviour {

	public Sprite coin; 
	public Sprite shadow; 
	public SpriteRenderer sr; 

	// Use this for initialization
	void Start () 
	{
		sr = GetComponent<SpriteRenderer>();  
	}
	
	// Update is called once per frame
	void Update () 
	{
  
	}


	public void imageChange()
	{
		sr.sprite = coin;  
	}

	public void imageNotChange()
	{
		sr.sprite = shadow; 
	}
}
