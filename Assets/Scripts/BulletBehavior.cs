using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {
    private Rigidbody rigidbody;
    public Vector3 velocity;
    public float timeTillDestroy = 1.0f;
    public float moveSpeed = 3.0f;
    public int damage = 10;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        velocity = rigidbody.velocity;
    }
    void Update() {
        velocity = velocity + this.transform.forward * moveSpeed;
        rigidbody.velocity = velocity;
        Destroy(gameObject, timeTillDestroy);
        gameObject.transform.Rotate(0, 0, 150 * Time.deltaTime);
    }

    public int GetDamage() {
        return damage;
    }

}
