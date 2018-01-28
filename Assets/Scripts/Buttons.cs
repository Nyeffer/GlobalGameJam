using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	
	private int NumOfCrystals;
	private float posX;
	private float posY;
	private float posZ;
	private string nameOfScene;

	private Vector3 playerPos;

	void Awake() {
		NumOfCrystals = PlayerPrefs.GetInt("numOfCrystals", 0);
		posX = PlayerPrefs.GetFloat("posX", 0);
		posY = PlayerPrefs.GetFloat("posY", 0);
		posZ = PlayerPrefs.GetFloat("posZ", 0);
		nameOfScene = PlayerPrefs.GetString("nameOfScene");
	}

	public void OnContinue() {
		if (nameOfScene != null) {
			SceneManager.LoadScene(nameOfScene, LoadSceneMode.Single);
		} 
	}

	public void OnStart() {
		PlayerPrefs.SetInt("numOfCrystals", 0);
		SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
	}

	public void Quit() {
		Application.Quit();
	}
}
