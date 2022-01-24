using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovementGreen : MonoBehaviour {

	ScoreManager ScoreBoard;
	public Rigidbody2D greenLaser;
	public float speed = 20f;
	int MeteorValue = 1;
	AudioSource greenMeteorSrc;

	void Start () {
		greenLaser.velocity = transform.up * speed;
		greenMeteorSrc = GetComponent<AudioSource>();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Meteor"){
			Destroy(other.gameObject);
			greenMeteorSrc.PlayOneShot(greenMeteorSrc.clip);
			ScoreManager.instance.AddPoint(MeteorValue);
		}
	}

	void OnBecameInvisible() {
		Destroy(gameObject);
	}
}