using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpPlayerPrefs : MonoBehaviour {

	private int curHealth;
	private int curNumCrytals;

	void Start() {
		curNumCrytals = PlayerPrefs.GetInt("CurrentNumberOfCrystals");
		if(curNumCrytals <= 0) {
			PlayerPrefs.SetInt("CurrentNumberOfCrystals", 0);
		}
	}

}
