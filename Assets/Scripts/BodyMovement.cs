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
	
	private Transform origPos_RA;
	private Transform origPos_RL;
	private Transform origPos_LA;
	private Transform origPos_LL;

	void Start() {
		direction = -1;
		origPos_LA = l_Arm.transform;
		origPos_LL = l_Leg.transform;
		origPos_RA = r_Arm.transform;
		origPos_RL = r_Leg.transform;
		
	}

	void Update() {
		if(counter <= 0.5) {
			counter += Time.deltaTime;
			if(Input.GetAxis("Vertical") > 0) {
				
				r_Arm.transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
				l_Arm.transform.Translate(0, 0, -Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
				r_Leg.transform.Translate(0, 0, -Input.GetAxis("Vertical") * Time.deltaTime *(direction * 0.25f));
				l_Leg.transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
			}  
			if (Input.GetAxis("Vertical") < 0) {

				r_Arm.transform.Translate(0, 0, -Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
				l_Arm.transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
				r_Leg.transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
				l_Leg.transform.Translate(0, 0, -Input.GetAxis("Vertical") * Time.deltaTime * (direction * 0.25f));
			} 
		} else {
			counter = 0;
			direction *= -1;
		}
		r_Arm.transform.position = origPos_RA.position;
		l_Arm.transform.position = origPos_LA.position;
		r_Leg.transform.position = origPos_RL.position;
		l_Leg.transform.position = origPos_LL.position;
	}

	
}
