using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSound : MonoBehaviour {
    public AudioSource Audio;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetMouseButtonDown(0)){
		Audio.PlayOneShot(Audio.clip);
	}	
	}
}
