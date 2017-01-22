using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepingTitle : MonoBehaviour {

    [SerializeField]
    float speed = 3f;
    [SerializeField]
    Vector3 finalPos;
    [SerializeField]
    float delay = 20f;

    bool active = false;

    void Start()
    {
        Invoke("Activate", delay);
    }

    void Activate()
    {
        active = true;
    }

	void Update () {
        if (!active)
            return;
        transform.position = Vector3.MoveTowards(transform.position,
            finalPos, speed * Time.deltaTime);
	}
}
