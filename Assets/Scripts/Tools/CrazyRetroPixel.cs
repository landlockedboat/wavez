using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyRetroPixel : MonoBehaviour {
    AlpacaSound.RetroPixel rt;
    [SerializeField]
    float hueSpeed = .3f;

    void Start () {
        rt = GetComponent<AlpacaSound.RetroPixel>();
    }

    void ChangeHue(ref Color col)
    {
        float hue, sat, val;
        Color.RGBToHSV(col, out hue, out sat, out val);
        float newHue = hue += hueSpeed * Time.deltaTime;
        if (newHue >= 1)
            newHue = 0;
        col = Color.HSVToRGB(newHue, sat, val);
    }
	
	void Update () {
        ChangeHue(ref rt.color0);
        ChangeHue(ref rt.color1);
        ChangeHue(ref rt.color2);
        ChangeHue(ref rt.color3);
        ChangeHue(ref rt.color4);
        ChangeHue(ref rt.color5);
        ChangeHue(ref rt.color6);
        ChangeHue(ref rt.color7);        
    }
}
