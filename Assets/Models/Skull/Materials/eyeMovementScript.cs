using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeMovementScript : MonoBehaviour {

    private Rigidbody rb;
    public float speed = 1.0f;
    public float movementDivisor = 1.0f;
    public float min = 1.0f;
    public float max = 2.0f;
    private float dir = 1.0f;
    private float a = 0.0f;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        a += speed * dir * Time.deltaTime;
        if (a < min)
        {
            dir = -dir;
            a = min;
        }
        if (a > max)
        {
            dir = -dir;
            a = max;
        }
        rb.transform.Translate((a / movementDivisor) * dir, 0, 0);
	}
}
