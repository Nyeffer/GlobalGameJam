using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatherCrystal : MonoBehaviour {

	public Text text_Crystal;

	private int numOfCrystal = 0;

	public Text text_Generator;

	void Start() {
		numOfCrystal = PlayerPrefs.GetInt("numOfCrystals");
	}
	
	void Update() {
		text_Crystal.text = GetNumOfCrystal().ToString();
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Crystal") {
			numOfCrystal++;
			Destroy(col.gameObject);
		}

		if(col.gameObject.tag == "Generator") {
			// col.GetComponent<>();
		}
	}

	public int GetNumOfCrystal() {
		return numOfCrystal;
	}

	public void TakeCrystals(int Crystals) {
		numOfCrystal -= Crystals;
	}
}
