using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public GameObject Enemy;
	float counter;

	void Start() {
		counter = 0;
	}

	void Update() {
		counter += Time.deltaTime;
		if (counter >= 5) {
			Instantiate(Enemy, gameObject.transform.position, Quaternion.identity);
			counter = 0;
		}
	}
}
