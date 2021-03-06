﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CheckWin : MonoBehaviour {

	private int gameScore;
	public TextMeshPro timerText;
	
	// Update is called once per frame
	void Update () 
	{
		timerText.text = "Time: " + Time.fixedTime.ToString ();	
		/*Finds the object tagged as player, then finds the script attached called AddPoints, then pulls out the score value*/
		gameScore = GameObject.FindWithTag ("player").GetComponent<AddPoints>().score;
		//Debug.Log ("Game score = " + gameScore);
		if (gameScore >= 10) 
		{
			Debug.Log ("WINNER!");
		} 
		else if (gameScore < 0) 
		{
			Debug.Log ("LOSER!");
		}

		if (Time.fixedTime > 30) 
		{
			SceneManager.LoadScene (2);
		}
	}
}
