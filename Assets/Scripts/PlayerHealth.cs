﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	public int maxHealth;
	private int curHealth;

	public int numOfCrystal;

	private string nameOfScene;

	public Slider hpBar;

	void Start() {
		curHealth = maxHealth;
		hpBar.maxValue = maxHealth;
		nameOfScene = SceneManager.GetActiveScene().ToString();
	}

	void Update() {
		hpBar.value = curHealth;
		if(curHealth <= 0) {
			Save();
		}
	}

	public int GetHealth() {
		return curHealth;
	}

	public void SetHealth(int health) {
		curHealth = health;
	}

	public void Save() {
		numOfCrystal = GetComponentInChildren<GatherCrystal>().GetNumOfCrystal();
		PlayerPrefs.SetInt("numOfCrystals", numOfCrystal);
		PlayerPrefs.SetFloat("posX", gameObject.transform.position.x);
		PlayerPrefs.SetFloat("posY", gameObject.transform.position.y);
		PlayerPrefs.SetFloat("posZ", gameObject.transform.position.z);
		PlayerPrefs.SetString("nameOfScene", nameOfScene);
	}

}
