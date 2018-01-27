using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalChecker : MonoBehaviour {

	public int requiredAmtOfCrystal = 0;
	private int playerAmtofCrystal;
	public GameObject TextPanel;
	public Text howManyCrystalLeft;

	void Awake() {
		TextPanel.SetActive(false);
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "PlayerInteract") {
			int numOfCrystals = col.GetComponent<GatherCrystal>().GetNumOfCrystal();
			if(numOfCrystals >= requiredAmtOfCrystal) {
				gameObject.SetActive(false);
			} else {
				TextPanel.SetActive(true);
				howManyCrystalLeft.text = "You Need " + (requiredAmtOfCrystal - numOfCrystals).ToString() + " More Crystals";
			}
		}
	}

	void OnTriggerExit(Collider col) {
		if(col.gameObject.tag == "PlayerInteract") {
			TextPanel.SetActive(false);
		}

	}
}
