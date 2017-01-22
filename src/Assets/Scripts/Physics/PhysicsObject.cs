using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : PhysicsEntity {
	void Start () {
        PhysicsController.Instance.AddPhysicsObject(gameObject);
    }
}
