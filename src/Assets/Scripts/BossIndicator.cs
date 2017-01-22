using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIndicator : Singleton<BossIndicator> {
    Transform bossTrans;
    bool active = false;

    public void Activate(Transform _bossTrans)
    {
        active = true;
        bossTrans = _bossTrans;
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void Deactivate()
    {
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
