using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour {
	public float moveSpeed;  
	public float timeOffset;

	// Use this for initialization
	void Start () {
		timeOffset = Random.Range (90f, 100f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(0f, Mathf.Sin (Time.time * 5f + timeOffset)* 0.00075f, 0f) * Time.deltaTime * moveSpeed; // float

	}
}
