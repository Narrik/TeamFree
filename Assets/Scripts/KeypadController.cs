﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadController : MonoBehaviour {
	public GameObject door;
	// Use this for initializationch
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator OnTriggerStay2D (Collider2D other){
		if ((other.tag == "President") && (Input.GetKey(KeyCode.Space))){
			door.GetComponent<BoxCollider2D> ().enabled = false;
			yield return new WaitForSeconds (2);
			door.GetComponent<BoxCollider2D> ().enabled = true;
	}
}
}
