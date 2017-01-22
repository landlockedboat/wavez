using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEntity : MonoBehaviour {

    new Rigidbody rigidbody;
    float angularFriction = 0.98f;
    float velocityFriction = 0.98f;

    void Awake () {
        rigidbody = GetComponent<Rigidbody>();
    }
	
	void Update () {
        rigidbody.angularVelocity *= angularFriction;
        rigidbody.velocity *= velocityFriction;
    }
}
