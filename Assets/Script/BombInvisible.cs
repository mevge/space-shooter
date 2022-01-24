using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInvisible : MonoBehaviour {

	void OnBecameInvisible() {
		Destroy(gameObject);	
	}
}
