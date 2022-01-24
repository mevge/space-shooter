using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserFire : MonoBehaviour {

	public Transform redLaserPoint;
	public Transform greenLaserPoint;
	public GameObject redLaser;
	public GameObject greenLaser;
	AudioSource fireSrc;

	void Start() {
		fireSrc = GetComponent<AudioSource>();
	}

	public void Fire() {

			Shoot();
	}

	void Shoot() {
		Instantiate(redLaser, redLaserPoint.position, redLaserPoint.rotation);
		Instantiate(greenLaser, greenLaserPoint.position, greenLaserPoint.rotation);
	}

	void AudioFire() {
		if(Input.GetMouseButtonDown(0)) {
			fireSrc.PlayOneShot(fireSrc.clip);
		}
	}

}
