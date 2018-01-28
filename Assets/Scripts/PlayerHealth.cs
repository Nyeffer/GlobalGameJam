﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	public int maxHealth;
	private float curHealth;

	public int numOfCrystal;

	private string nameOfScene;

	public Slider hpBar;

	void Start() {
		numOfCrystal = PlayerPrefs.GetInt("numOfCrystals", 0);
		curHealth = maxHealth;
		hpBar.maxValue = maxHealth;
		nameOfScene = SceneManager.GetActiveScene().ToString();
	}

	void Update() {
		hpBar.value = curHealth;
		if(curHealth <= 0) {
			Save();
			SceneManager.LoadScene("GameOver", LoadSceneMode.Single)
		}
	}

	public float GetHealth() {
		return curHealth;
	}

	public void SetHealth(int health) {
		curHealth = health;
	}

	public void DealDamage(int Damage) {
		curHealth -= Damage;
	}

	public void DamageOverTime() {
		curHealth -= Time.deltaTime;
	}

	public void DamageOverTime(int multiplier) {
		curHealth -= Time.deltaTime * multiplier;
	}

	public void Save() {
		numOfCrystal = GetComponentInChildren<GatherCrystal>().GetNumOfCrystal();
		PlayerPrefs.SetInt("numOfCrystals", numOfCrystal);
		PlayerPrefs.SetString("nameOfScene", nameOfScene);
	}

}
