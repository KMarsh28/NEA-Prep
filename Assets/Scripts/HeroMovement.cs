using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour {

	Rigidbody2D rb;
	float speed;

	// Use this for initialization
	void Start () 
	{
		speed = 3.1f;
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.D))
		{
			rb.AddForce(new Vector2(1, 0), ForceMode2D.Impulse);
		}
		if (Input.GetKey(KeyCode.A))
		{
			rb.AddForce(new Vector2(-1, 0), ForceMode2D.Impulse);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
		}
	}
}
