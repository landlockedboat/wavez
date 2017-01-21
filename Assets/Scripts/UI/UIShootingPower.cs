using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShootingPower : MonoBehaviour {
    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "time = " + Shooting.Instance.CurrentBulletForce.ToString("F2");

    }
}
