using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeChange : MonoBehaviour {
 
	bool incScale;

	float xTarget;
	float yTarget;

	public float scaleSpeed;
	public float scaleSize; 


	// Use this for initialization
	void Start () {  
		incScale = true; 
	}
	
	// Update is called once per frame
	void Update () {

		if (incScale) 
		{
			if (xTarget < scaleSize) 
			{
				xTarget += scaleSpeed; 
				yTarget += scaleSpeed; 
			} 

			else 
			{
				incScale = false;
			}
		} 

		else 
		{
			if (xTarget > 0) 
			{
				xTarget -= scaleSpeed; 
				yTarget -= scaleSpeed; 
			}

			else
			{
				incScale = true; 
			}
		}

		transform.localScale = new Vector3 (1 + xTarget, 1 + yTarget, 1);  
	}
}
