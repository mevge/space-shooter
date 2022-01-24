using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody2D myRb;
	public bl_Joystick Joystick;
	float speed = 0.5f;
	float v,h;
	AudioSource playerSrc;

	void Start () {
		myRb = GetComponent<Rigidbody2D>();
		playerSrc = GetComponent<AudioSource>();
	}

	void FixedUpdate() {
		v = Joystick.Vertical;
		h = Joystick.Horizontal;

		transform.up = new Vector2(h * speed, v * speed);
		transform.Translate(new Vector2(h, v) * speed * Time.deltaTime, Space.World);
		transform.Rotate(0f, 180f, 0f);	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Meteor" || other.gameObject.tag == "Bomb") {
			Destroy(other.gameObject);
			playerSrc.Play();
			SceneManager.LoadScene("Scene01");
		}
	}
}
