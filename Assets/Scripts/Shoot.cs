using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	public Transform nuzzle;

	public float fireRate;
	public float lastFired;

	void Start() {
		fireRate = 2.0f;
		lastFired = 3f;
	}

	void Update() {
		if(Input.GetKey(KeyCode.Space)) {
			if(lastFired > 1/fireRate) {
				Instantiate(bullet, nuzzle.transform.position, nuzzle.transform.rotation);
				lastFired = 0.0f;
			} else {
				lastFired += Time.deltaTime;
			}
		}
	}
}
