using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetChildrenActiveAt : MonoBehaviour {
    [SerializeField]
    float delay;

    void Start () {
        Invoke("Activate", delay);
	}
	
    void Activate()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
