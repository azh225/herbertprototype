using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour {

	// update score here
	// change scenes (make a game over scene) 

	public static GameManager instance; 



	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void GoToMainMenu () {
		SceneManager.LoadScene ("MainMenu"); 

	}

	public void GoToLevelOne () {
		SceneManager.LoadScene ("Playground"); 

	}

	public void GoToLevelTwo () {
		SceneManager.LoadScene ("JellyfishLevel01"); 

	}

	public void GoToLevelThree () {
		SceneManager.LoadScene ("JellyfishLevel02"); 

	}

	public void GoToLevelFour() {
		SceneManager.LoadScene ("crabLevel01"); 

	}

	public void GoToLevelFive() {
		SceneManager.LoadScene ("octopusLevel01"); 

	}

	public void GoToLevelSix() {
		SceneManager.LoadScene ("crabOctopusLevel"); 

	}
}
