using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour {
    new Rigidbody rigidbody;
    float angularFriction = 0.98f;
    float velocityFriction = 0.98f;
	void Start () {
        PhysicsController.Instance.AddPhysicsObject(gameObject);
        rigidbody = GetComponent<Rigidbody>();
    }
	
	void Update () {
        rigidbody.angularVelocity *= angularFriction;
        rigidbody.velocity *= velocityFriction;

    }
}
