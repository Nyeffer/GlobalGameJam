using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorActivate : MonoBehaviour {

	public int requiredAmtOfCrystal = 0;
	private int playerAmtofCrystal;
	public GameObject TextPanel;
	public GameObject ButtonPanel;
	public Text howManyCrystalLeft;
	public Button ActivateGenerator;
	private GameObject Player;

	public Material ActiveState;
	public Material DeactiveState;

	private Renderer rend;

	void Awake() {
		TextPanel.SetActive(false);
		ButtonPanel.SetActive(false);
		rend = gameObject.GetComponent<Renderer>();
		rend.material = DeactiveState;
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "PlayerInteract") {
			Player = col.gameObject;
			int numOfCrystals = col.GetComponent<GatherCrystal>().GetNumOfCrystal();
			if(numOfCrystals < requiredAmtOfCrystal) {
				TextPanel.SetActive(true);
				howManyCrystalLeft.text = "You Need " + (requiredAmtOfCrystal - numOfCrystals).ToString() + " More Crystals";
			} else {
				ButtonPanel.SetActive(true);
			}			
		}
	}

	void OnTriggerExit(Collider col) {
		Player = null;
		if(col.gameObject.tag == "PlayerInteract") {
			TextPanel.SetActive(false);
			ButtonPanel.SetActive(false);
		}
	}

	public void TakeCrystal() {
		Debug.Log("Pressed");
		if (requiredAmtOfCrystal <= Player.GetComponent<GatherCrystal>().GetNumOfCrystal()) {
			Player.GetComponent<GatherCrystal>().TakeCrystals(requiredAmtOfCrystal);
			rend.material = ActiveState;
		}
	} 
	
}
