using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioClip coin;
	private AudioSource source;

	// Use this for initialization
	void Awake () 
	{
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col) 
	{
		//Debug.Log ("bing!");
		source.PlayOneShot (coin, 1);
	}
}
