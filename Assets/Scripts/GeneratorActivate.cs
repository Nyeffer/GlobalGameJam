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

	public GameObject EnemySpawners;

	public GameObject Crystals;

	public Material ActiveState;
	public Material DeactiveState;
	public MeshFilter ActivatedGen;

	private Renderer rend;

	void Awake() {
		TextPanel.SetActive(false);
		ButtonPanel.SetActive(false);
		rend = gameObject.GetComponent<Renderer>();
		rend.material = DeactiveState;
		Crystals.SetActive(false);
		EnemySpawners.SetActive(true);
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
				MeshFilter mesh = GetComponent<MeshFilter>();
				mesh = ActivatedGen;
				Crystals.SetActive(true);
				EnemySpawners.SetActive(false);
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
		if (requiredAmtOfCrystal <= Player.GetComponent<GatherCrystal>().GetNumOfCrystal()) {
			Player.GetComponent<GatherCrystal>().TakeCrystals(requiredAmtOfCrystal);
			rend.material = ActiveState;
		}
	} 
	
}
