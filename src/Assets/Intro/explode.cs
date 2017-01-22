using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour {

    Rigidbody rb;
    public float fact = 1.001f;
    public GameObject go;
    public GameObject title;
    public GameObject waiter;
    // Use this for initialization
	void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale += new Vector3 (fact,fact,fact);
        if (transform.localScale.x > 9.1f)
        {
            go.SetActive(false);
            title.SetActive(true);
            waiter.SetActive(true);
        }
	}
}
