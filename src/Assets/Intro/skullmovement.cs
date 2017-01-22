using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skullmovement : MonoBehaviour {

    public Transform camPos;
    public float speed = 0.5f;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.transform.LookAt(camPos);
        //skull.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position += Vector3.forward * Time.deltaTime * speed;
    }
}
