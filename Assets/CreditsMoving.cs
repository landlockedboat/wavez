using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMoving : MonoBehaviour {
    [SerializeField]
    float speed = 3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float deltaSpeed = speed * Time.deltaTime;
        transform.position = transform.position - transform.forward  * deltaSpeed;
    }
}
