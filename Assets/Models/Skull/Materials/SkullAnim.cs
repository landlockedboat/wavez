using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullAnim : MonoBehaviour {

    public float timeBetweenLaugh = 10.0f;
    public float laughDuration = 3.0f;
    public GameObject eyes;
    private float t = 0.0f;
    private bool laughing = false;

    private Animator anim;
    private AudioSource audio;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        t += 1.0f * Time.deltaTime;
        if (t > timeBetweenLaugh && laughing == false)
        {
            anim.SetBool("Laugh", true);
            audio.Play();
            laughing = true;
            MeshRenderer m = eyes.GetComponent<MeshRenderer>();
            m.enabled = true;
        }
        if (t > timeBetweenLaugh + laughDuration && laughing == true)
        {
            anim.SetBool("Laugh", false);
            laughing = false;
            audio.Stop();
            t = 0.0f;
            MeshRenderer m = eyes.GetComponent<MeshRenderer>();
            m.enabled = false;
        }
	}
}
