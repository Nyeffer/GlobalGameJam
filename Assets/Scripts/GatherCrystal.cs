using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatherCrystal : MonoBehaviour {

	public Text text_Crystal;

	private int numOfCrystal = 0;
	
	void Update() {
		text_Crystal.text = GetNumOfCrystal().ToString();
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Crystal") {
			numOfCrystal++;
			Destroy(col.gameObject);
		}
	}

	public int GetNumOfCrystal() {
		return numOfCrystal;
	}

}
