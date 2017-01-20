using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour {
    float  maxDegreesPerSecond = 30.0f;
    Quaternion qTo;
	// Use this for initialization
	void Start () {
        qTo = transform.localRotation;

    }

    // Update is called once per frame
    void Update () {
        Vector2 mousePos = MouseInputController.Instance.GetMouseScreenCoords();
        Vector2 actPos = transform.position;

        // Get Angle in Radians
        float AngleRad = Mathf.Atan2(mousePos.y - actPos.y, mousePos.x - actPos.x);
        // Get Angle in Degrees
        float AngleDeg = (180 / Mathf.PI) * AngleRad;

        transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

    }
}
