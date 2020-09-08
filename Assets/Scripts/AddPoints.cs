using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddPoints : MonoBehaviour {

	private int score;
	public TextMeshPro scoreText;

	void Start ()
	{
		score = 0;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "collectible5pt")
		{
			Debug.Log ("5 points were added");
			Destroy (col.gameObject);
			score += 5;
			scoreText.text = "Score: " + score.ToString ();
		}

		if (col.gameObject.tag == "minus10pt")
		{
			Debug.Log ("10 points were removed");
			Destroy (col.gameObject);
			score -= 10;
			scoreText.text = "Score: " + score.ToString ();
		}
	}
}
