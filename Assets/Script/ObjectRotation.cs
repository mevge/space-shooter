using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour {


	void Update () {
		transform.Rotate(new Vector3(0, 0, 100f) * Time.deltaTime);		
	}

	void OnBecameInvisible() {
		Destroy(gameObject);	
	}
}
