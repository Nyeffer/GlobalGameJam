using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour {

	public GameObject Spawner;

	void Awake() {
		Spawner.SetActive(false);
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Player") {
			Spawner.SetActive(true);
		}
	}

	void OnTriggerExit(Collider col) {
		if(col.gameObject.tag == "Player") {
			Spawner.SetActive(false);
		}
	}


}
