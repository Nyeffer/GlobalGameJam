using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial_Done : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Player") {
			SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
		}
	}
}
