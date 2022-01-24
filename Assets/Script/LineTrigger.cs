using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LineTrigger : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Meteor") {
			SceneManager.LoadScene("Scene01");
		}
	}
}
