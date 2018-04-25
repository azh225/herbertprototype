using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenShake : MonoBehaviour {

	public static float shakeTimer;
	public static float shakeAmount;
	public static Vector3 originalCameraPos = new Vector3(0f,0f,-10f);
	public static bool shakeScreen = false;
	public static bool shellShake = false; 
	public static bool playOnce = false; 

	// Use this for initialization
	void Start () {
		originalCameraPos = new Vector3(0,0,-10);
	}

	// Update is called once per frame
	void LateUpdate () {

		if (playOnce) {
			playOnce = false;
		}
			
		// handle screen shake 
		if (shakeScreen) {

			transform.localPosition  = originalCameraPos + new Vector3(Random.value * shakeTimer * shakeAmount, 
				Random.value * shakeTimer * shakeAmount, 
				-10);
		} else {
			transform.localPosition  = originalCameraPos; 
		}
			

		if (shakeTimer > 0){
			shakeTimer -= Time.unscaledDeltaTime;
			if (shakeTimer < 0) shakeTimer = 0;
		}

	}
}