using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpFxLogic : MonoBehaviour {
    AudioSource auS;
    [SerializeField]
    float minPitch = 0.5f;
    [SerializeField]
    float maxPitch = 1.5f;

    ParticleSystem ps;
	void Awake() {
        ps = GetComponent<ParticleSystem>();
        auS = GetComponent<AudioSource>();
    }

    void Start()
    {
        auS.pitch = Random.Range(minPitch, maxPitch);
    }

    // Update is called once per frame
    void Update () {
        if (!ps.IsAlive())
            Destroy(gameObject);
	}
}
