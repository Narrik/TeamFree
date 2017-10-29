﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletControllerAlienPresident : MonoBehaviour {

	public float speed;
	public PresidentController president;

	private Vector3 shootDirection;

	// Use this for initialization
	void Start ()
	{
		president = FindObjectOfType<PresidentController> ();
		shootDirection = (president.transform.position - transform.position).normalized;
	}

	void FixedUpdate () {


		GetComponent<Rigidbody2D> ().velocity = new Vector2 ((shootDirection.x)*speed,(shootDirection.y)*speed);
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if ((other.collider.tag == "President") || (other.collider.tag == "Bodyguard")) {
			Destroy (other.gameObject);
			SceneManager.LoadScene ("Level1");
		}

		if (!((other.collider.tag == "Alien") || other.collider.tag == "Bullet")) {
			Destroy (gameObject);
		}


	}
}
