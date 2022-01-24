using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	AudioSource buttonSrc;

	void Start() {
		buttonSrc = GetComponent<AudioSource>();	
	}

	public void StartGame() {
		SceneManager.LoadScene("Scene02");

	}

	public void ResetValue() {
		PlayerPrefs.DeleteKey("Highscore");
	}

	public void ButtonAudio() {
		if(Input.GetMouseButtonDown(0)) {
			buttonSrc.PlayOneShot(buttonSrc.clip);
		}
	}
}
