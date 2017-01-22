using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCredits : MonoBehaviour {

    public Rigidbody rb;
    public GameObject skull;
    public GameObject text;
    public GameObject explosion;
    public AudioSource exploSound;
    public AudioSource fuseSound;

    public float speed = 0.5f;
    private bool ready = false;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        skull.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		rb.transform.position += Vector3.forward * Time.deltaTime * speed;
        if (rb.transform.position.z > 1.4f && !ready)
        {
            text.SetActive(false);
            skull.SetActive(true);
            if (!fuseSound.isPlaying) fuseSound.Play();
        }
        if (rb.transform.position.z > 3.3f && !ready)
        {
            ready = true;
            skull.SetActive(false);
            explosion.SetActive(true);
            fuseSound.Stop();
            if (!exploSound.isPlaying) exploSound.Play();
        }
    }
}
