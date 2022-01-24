using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovementRed : MonoBehaviour {

	ScoreManager ScoreBoard;
	public Rigidbody2D redLaser;
	public float speed = 20f;
	int MeteorValue = 1;
	AudioSource redMeteorSrc;
	

	void Start () {
		redLaser.velocity = transform.up * speed;
		redMeteorSrc = GetComponent<AudioSource>();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Meteor"){
			Destroy(other.gameObject);
			redMeteorSrc.PlayOneShot(redMeteorSrc.clip);
			ScoreManager.instance.AddPoint(MeteorValue);
		}
	}

	void OnBecameInvisible() {
		Destroy(gameObject);
	}
}