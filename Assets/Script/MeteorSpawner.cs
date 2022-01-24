using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour {

	public GameObject[] Objects;
	public float wait;
	public float lessWait;
	public float mostWait;
	public float startWait;
	bool stop = true;
	int randObjects;


	void Start () {

		StartCoroutine(objectSpawner());
		
	}
	
	
	void Update () {
		
		wait = Random.Range(lessWait, mostWait);

	}

	IEnumerator objectSpawner() {
		yield return new WaitForSeconds(startWait);

		while (stop)
		{
			randObjects = Random.Range(0, Objects.Length);
			Vector3 pos = new Vector3(Random.Range(-1.60f, 2.5f), 0, 0);
			Instantiate(Objects[randObjects], pos + transform.TransformPoint(0,0,0), gameObject.transform.rotation);
			yield return new WaitForSeconds(wait);
		}
	}
}
