using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {
    [SerializeField]
    float delay;

	void Start () {
        Invoke("Kys", delay);
	}
    void Kys()
    {
        Destroy(gameObject);
    }
}
