using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : Singleton<CameraShake> {
    float duration, magnitude, elapsed;
    Vector3 originalCamPos;
    bool shaking = false;

    public void ShakeIt(float _duration, float _magnitude)
    {
        duration = _duration;
        magnitude = _magnitude;
        StopAllCoroutines();
        if (shaking)
            Camera.main.transform.position = originalCamPos;
        StartCoroutine("Shake");
    }

    IEnumerator Shake()
    {
        shaking = true;
        elapsed = 0.0f;

        originalCamPos = Camera.main.transform.position;

        while (elapsed < duration)
        {

            elapsed += Time.deltaTime;

            float percentComplete = elapsed / duration;
            float damper = 1.0f - Mathf.Clamp(4.0f * percentComplete - 3.0f, 0.0f, 1.0f);

            // map value to [-1, 1]
            float x = Random.value * 2.0f - 1.0f;
            float y = Random.value * 2.0f - 1.0f;
            x *= magnitude * damper;
            y *= magnitude * damper;

            x += originalCamPos.x;
            y += originalCamPos.y;

            Camera.main.transform.position = new Vector3(x, y, originalCamPos.z);

            yield return null;
        }

        Camera.main.transform.position = originalCamPos;
        shaking = false;
    }
}
