using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIndicator : MonoBehaviour {
    [SerializeField]
    Vector2 bossPos;
    [SerializeField]
    float bossHeight;


    void Update()
    {
        Quaternion rot = Quaternion.Euler(0, 0,
            180 + Utilts.GetAngleBetween(transform.position, bossPos));
        transform.localRotation = rot;
    }
}
