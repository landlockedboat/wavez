using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHide : MonoBehaviour {
    [SerializeField]
    float duration = 5f;

    void OnEnable () {
        Invoke("Deactivate", duration);
	}

    void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
