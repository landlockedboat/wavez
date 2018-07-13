using UnityEngine;

public class ScreenGrab : MonoBehaviour {
    [SerializeField]
    int superSize = 2;

	void Update () {
        if (Input.GetKeyDown(KeyCode.S))
        {
            ScreenCapture.CaptureScreenshot(Time.time.ToString("F0") + ".png", superSize);
        }
	}
}
