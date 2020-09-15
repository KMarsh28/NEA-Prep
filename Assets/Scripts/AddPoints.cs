using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddPoints : MonoBehaviour {

	public int score;
	public TextMeshPro scoreText;
	private GameObject[] collect5ptArray;
	public int count5pt;
	public TextMeshPro goodText;
	private GameObject[] minus10ptArray;
	private int minus10pt;
	public TextMeshPro badText;

	void Start ()
	{
		score = 0;
		collect5ptArray = GameObject.FindGameObjectsWithTag ("collectible5pt");
		count5pt = collect5ptArray.Length;
		goodText.text = "Good: " + count5pt.ToString ();
		minus10ptArray = GameObject.FindGameObjectsWithTag ("minus10pt");
		minus10pt = minus10ptArray.Length;
		badText.text = "Bad: " + minus10pt.ToString ();
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "minus10pt")
		{
			Debug.Log ("10 points were removed");
			Destroy (col.gameObject);
			score -= 10;
			scoreText.text = "Score: " + score.ToString ();
			minus10pt -= 1;
			badText.text = "Bad: " + minus10pt.ToString ();
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "collectible5pt")
		{
			Debug.Log ("5 points were added");
			Destroy (col.gameObject);
			score += 5;
			scoreText.text = "Score: " + score.ToString ();
			count5pt -= 1;
			goodText.text = "Good: " + count5pt.ToString ();
		}
	}
}
