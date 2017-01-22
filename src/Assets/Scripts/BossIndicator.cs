using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIndicator : Singleton<BossIndicator> {
    [SerializeField]
    AudioClip bossMusic;
    [SerializeField]
    AudioClip normalMusic;

    AudioSource aus;
    Transform bossTrans;
    bool active = false;

    void Start()
    {
        aus = Camera.main.GetComponent<AudioSource>();
    }

    public void Activate(Transform _bossTrans)
    {
        aus.clip = bossMusic;
        aus.Play();
        active = true;
        bossTrans = _bossTrans;
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        aus.clip = normalMusic;
        aus.Play();
        active = false;
        transform.GetChild(0).gameObject.SetActive(false);
    }

    void Update()
    {
        if (!active)
            return;
        Quaternion rot = Quaternion.Euler(0, 0,
            180 + Utilts.GetAngleBetween(transform.position, bossTrans.position));
        transform.localRotation = rot;
    }
}
