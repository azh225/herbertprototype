using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour {

	public static int currentLevel;

	// update score here
	// change scenes (make a game over scene) 

	public static GameManager instance; 



	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

	}
	public void GoToIntro () {
		SceneManager.LoadScene ("Intro"); 
	}

	public void GoToMainMenu () {
		SceneManager.LoadScene ("MainMenu"); 
	}

	public void RetryLevel() {
		if (currentLevel == 1) {
			SceneManager.LoadScene ("Level1Playground");
			Debug.Log ("i'm RETURNING to level 1"); 
		} else if (currentLevel == 2) {
			SceneManager.LoadScene ("Level2Jelly");
			Debug.Log ("i'm RETURNING to level 2"); 
		}  else if (currentLevel == 3) {
			SceneManager.LoadScene ("Level3Crab"); 
			Debug.Log ("i'm RETURNING to level 3"); 
		}  else if (currentLevel == 4) {
			SceneManager.LoadScene ("Level4JellyCrab"); 
			Debug.Log ("i'm RETURNING to level 4"); 
		}  else if (currentLevel == 5) {
			SceneManager.LoadScene ("Level5Octo"); 
			Debug.Log ("i'm RETURNING to level 5"); 
		}  else if (currentLevel == 6) {
			SceneManager.LoadScene ("Level6OctoCrab"); 
			Debug.Log ("i'm RETURNING to level 6"); 
		} 
	}

	public void GoToLevelOne () {
		SceneManager.LoadScene ("Level1Playground"); 
		Debug.Log ("i'm on level 1"); 
		currentLevel = 1; 
	}

	public void GoToLevelTwo () {
		SceneManager.LoadScene ("Level2Jelly");
		Debug.Log ("i'm on level 2"); 
		currentLevel = 2;
	}

	public void GoToLevelThree () {
		SceneManager.LoadScene ("Level3Crab"); 
		Debug.Log ("i'm on level 3"); 
		currentLevel = 3;
	}

	public void GoToLevelFour() {
		SceneManager.LoadScene ("Level4JellyCrab");
		Debug.Log ("i'm on level 4"); 
		currentLevel = 4;
	}

	public void GoToLevelFive() {
		SceneManager.LoadScene ("Level5Octo"); 
		Debug.Log ("i'm on level 5"); 
		currentLevel = 5;
	}

	public void GoToLevelSix() {
		SceneManager.LoadScene ("Level6OctoCrab"); 
		Debug.Log ("i'm on level 6"); 
		currentLevel = 6;
	}
}
