using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int score = 0; 
	public Text ScoreText; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log ("SCORE: " + score);
		ScoreText.text = "score: " + score; 
	}
}
