using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratorCheck : MonoBehaviour {

	public GameObject[] generator;
	public GameObject TextPanel;
	public Text NumOfGeneratorsLeft;
	private int numOfGenerator;
	private int numOfActiveGen;
	public bool isComplete;

	void Start() {
		isComplete = false;
		TextPanel.SetActive(false);
		numOfGenerator = generator.Length;
		for (int i = 0; i < numOfGenerator; i++) {
			if(generator[i].GetComponent<GeneratorActivate>().GetState()) {
				numOfActiveGen++;
			}		
		}
	}

	void Update() {
		if(numOfActiveGen >= numOfGenerator) {
			isComplete = true;
		}
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "PlayerInteract") {
			if(!isComplete) {
				TextPanel.SetActive(true);
				NumOfGeneratorsLeft.text = (numOfGenerator - numOfActiveGen).ToString() + " Generators Left";
			}
		}
	}

	public bool GetState() {
		return isComplete;
	}
}
