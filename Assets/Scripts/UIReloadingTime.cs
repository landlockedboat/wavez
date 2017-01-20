using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIReloadingTime : MonoBehaviour {
    Text text;
    float reloadingTime;
	// Use this for initialization
	void Start () {
        reloadingTime = Shooting.Instance.ReloadTime;
        text = GetComponent<Text>();
    }
	
	void Update () {
        bool reloading = Shooting.Instance.Reloading;
        if (reloading)
        {
            string currentReloadTime = Shooting.Instance.CurrentReloadTime.ToString("F2");
            string reloadTime = Shooting.Instance.ReloadTime.ToString("F2");
            text.text = "Reloading... " + currentReloadTime + "/" + reloadTime;
        }
        else
        {
            text.text = "Ready to rumble";
        }
    }
}
