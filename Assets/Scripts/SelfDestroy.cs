using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour {

	public float timeTillDestroy = 1.0f;

	void Start() {
		Destroy(gameObject, timeTillDestroy);
	} 


}
