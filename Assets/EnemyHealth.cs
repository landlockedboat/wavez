using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    [SerializeField]
    int maxHealth = 2;
    int currentHealth;
	// Use this for initialization
	void Awake () {
        currentHealth = maxHealth;
    }

    void Stun()
    {
        --currentHealth;
        if (currentHealth <= 0)
            PhysicsController.Instance.RemovePhysicsObject(gameObject);
            Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
