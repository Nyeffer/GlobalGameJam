using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRot : MonoBehaviour {

	public float rotSpeed = 150.0f;

	void Update() {
		gameObject.transform.Rotate(0, rotSpeed * Time.deltaTime, 0);
	}
}
