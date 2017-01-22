using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInRetroPixel : MonoBehaviour {
    [SerializeField]
    float fadeInSpeed = 3f;

    AlpacaSound.RetroPixel rt;
    float maxResX, maxResY, currResX, currResY;

    bool done = false;

    void Start () {
        rt = GetComponent<AlpacaSound.RetroPixel>();
        maxResX = rt.horizontalResolution;
        maxResY = rt.verticalResolution;
        currResX = currResY = 0;

        rt.horizontalResolution = (int)currResX;
        rt.verticalResolution = (int)currResY;        
    }
	
	// Update is called once per frame
	void Update () {
        if (done)
            return;

        currResX += fadeInSpeed * Time.deltaTime;
        currResY += fadeInSpeed * Time.deltaTime;
        if(currResX > maxResX ||currResY > maxResY)
        {
            currResX = maxResX;
            currResY = maxResY;
            done = true;
        }
        rt.horizontalResolution = (int)currResX;
        rt.verticalResolution = (int)currResY;
    }
}
