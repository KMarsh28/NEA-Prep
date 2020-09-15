using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoAnimation : MonoBehaviour {

	Animator myAnimator;

	// Use this for initialization
	void Start () 
	{
		myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.D)) 
		{
			myAnimator.SetBool ("walk", true);
		} 
		else 
		{
			myAnimator.SetBool ("walk", false);
		}

		if (Input.GetKey (KeyCode.Space)) 
		{
			myAnimator.SetBool ("jump", true);
		} 
		else 
		{
			myAnimator.SetBool ("jump", false);
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			myAnimator.SetBool ("dead", true);
		} 
		else if (Input.GetKey (KeyCode.Q) && myAnimator.GetBool ("dead") == true) 
		{
			Debug.Log ("spawn");
			myAnimator.Play ("Respawn");
			myAnimator.SetBool ("dead", false);
		}

		if (Input.GetKey (KeyCode.R)) 
		{
			myAnimator.SetBool ("run", true);
		} 
		else 
		{
			myAnimator.SetBool ("run", false);
		}
	}
}
