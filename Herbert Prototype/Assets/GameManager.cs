using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour {

	// update score here
	// change scenes (make a game over scene) 


	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) 
		{
			SceneManager.LoadScene ("Level 1"); 
		}
			
	}
		
			


}
