using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {
    [SerializeField]
    float rotSpeed = 6f;
    bool ded = false;

    public void Kill()
    {
        ded = true;
    }

    void Update () {
        if (ded)
            return;
        transform.Rotate(Vector3.forward, rotSpeed * Time.deltaTime);
	}
}
