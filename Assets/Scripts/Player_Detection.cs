using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Detection : MonoBehaviour {
	private GameObject target;
	private Rigidbody rb;
	public Vector3 velocity;
	public bool isSeeking;
	public float moveSpeed;
	private int numOfPoints;
	
	int counter = 0;

	public float distanceToSeek = 10;

	void Awake() {
		rb = GetComponent<Rigidbody>();
		velocity = rb.velocity;
	}


	void FixedUpdate() {
		if(isSeeking) {
			// bool isSlowed = false;
			if(target != null) {
				if(Vector3.Distance(target.transform.position, this.transform.position) < distanceToSeek) {
					Vector3 pos = target.transform.position - this.transform.position;
					this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(pos), 0.1f);

					if(pos.magnitude > 3) {
						this.transform.Translate(0, 0, moveSpeed * Time.deltaTime);
					} else {
						this.transform.Translate(0, 0, moveSpeed * 0.25f * Time.deltaTime);
					}
				}
			}
		} 
	}

	void OnTriggerEnter(Collider col) {
		if(col.gameObject.tag == "Player") {
			target = col.gameObject;
			isSeeking = true;	
		}
	}
}
