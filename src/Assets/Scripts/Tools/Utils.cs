using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilts {
    public static float GetAngleBetween(Vector2 v1, Vector2 v2)
    {
        float AngleRad = Mathf.Atan2(v1.y - v2.y, v1.x - v2.x);
        float AngleDeg = (180 / Mathf.PI) * AngleRad;
        return AngleDeg;
    }
}
