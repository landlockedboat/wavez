using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIReloadingTime : MonoBehaviour {
    Text text;
    float reloadingTime;

	void Start () {
        reloadingTime = Shooting.Instance.ReloadTime;
        text = GetComponent<Text>();
    }
	
	void Update () {
        bool reloading = Shooting.Instance.Reloading;
        if (reloading)
        {
            string currentReloadTime = Shooting.Instance.CurrentReloadTime.ToString("F2");
            text.text = "Reloading... " + currentReloadTime + "/" + reloadingTime;
        }
        else
        {
            text.text = "Ready to rumble";
        }
    }
}
