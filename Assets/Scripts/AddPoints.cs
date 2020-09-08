using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "collectible5pt")
		{
			Debug.Log ("5 points were added");
			Destroy (col.gameObject);
		}
	}
}
