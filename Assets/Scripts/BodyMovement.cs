using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMovement : MonoBehaviour {

	public GameObject r_Arm;
	public GameObject l_Arm;
	public GameObject r_Leg;
	public GameObject l_Leg;

	private float direction;
	private float counter;
	
	void Start() {
		direction = -1;
	}

	void Update() {
		if(counter <= 2) {
			counter += Time.deltaTime;
			if(Input.GetAxis("Vertical") > 0) {
				r_Arm.transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
				l_Arm.transform.Translate(0, 0, -Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
				r_Leg.transform.Translate(0, 0, -Input.GetAxis("Vertical") * Time.deltaTime *(direction * 0.25f));
				l_Leg.transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
			} else if (Input.GetAxis("Vertical") < 0) {
				r_Arm.transform.Translate(0, 0, -Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
				l_Arm.transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
				r_Leg.transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime *(direction * 0.25f));
				l_Leg.transform.Translate(0, 0, -Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
			}
		} else {
			counter = 0;
			direction *= -1;
		}

	}

	
}
