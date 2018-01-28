using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial_Done : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "PlayerInteract") {
			PlayerPrefs.SetInt("numOfCrystals", col.GetComponent<GatherCrystal>().GetNumOfCrystal());
			SceneManager.LoadScene("R1_L1", LoadSceneMode.Single);
		}
	}
}
