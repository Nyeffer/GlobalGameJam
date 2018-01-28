using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	private int dam;
	public int maxHealth;
	private int curHealth;

	void Start() {
		curHealth = maxHealth;
	}

	void Update() {
		if(curHealth <= 0) {
			gameObject.GetComponentInParent<Player_Detection>().selfDestroy();
		}
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "PlayerBullet") {
			dam = col.gameObject.GetComponent<BulletBehavior>().damage;
			curHealth -= dam;
			Destroy(col.gameObject);
		}
	}
}
