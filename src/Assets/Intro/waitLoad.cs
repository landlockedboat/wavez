using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitLoad : MonoBehaviour {

    private float t = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime * 20;
        transform.Translate(new Vector3(Mathf.Sin(t)/10, Mathf.Sin(t)/10, Mathf.Sin(t)/10));
	}
}
