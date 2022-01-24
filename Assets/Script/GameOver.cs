using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	AudioSource bombSrc;
	public AudioClip loseAudio;

	void Start() {
		bombSrc = gameObject.AddComponent<AudioSource>();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Bomb") {
			Destroy(other.gameObject);
			bombSrc.PlayOneShot(loseAudio);
			SceneManager.LoadScene("Scene01");
		}	
	}
}
