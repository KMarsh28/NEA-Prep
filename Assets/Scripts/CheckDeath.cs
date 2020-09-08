using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckDeath : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "deathZone")
		{
			//Debug.Log("I collided with the " + col.gameObject.tag);
			//Destroy(gameObject);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			Debug.Log ("You died.");
		}
	}
}
