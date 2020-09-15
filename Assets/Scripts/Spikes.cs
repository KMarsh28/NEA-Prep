using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

	Transform heroTR;

	// Use this for initialization
	void Start () 
	{
		heroTR = GameObject.FindGameObjectWithTag ("hero").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		//Debug.Log ("SPIKED!");
		heroTR.SetPositionAndRotation(new Vector3(-5.5f, 1.265f, 0), Quaternion.identity);
	}
}
