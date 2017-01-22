using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour {
    Text text;
    [SerializeField]
    float blinkTime = .2f;

    void Start()
    {
        text = GetComponent<Text>();
        StartCoroutine("Blinker");
    }

    IEnumerator Blinker()
    {
        Color noAlpha = text.color;
        noAlpha.a = 0;
        text.color = noAlpha;
        yield return new WaitForSeconds(blinkTime);
        Color alpha = text.color;
        alpha.a = 1;
        text.color = alpha;
        yield return new WaitForSeconds(blinkTime);
        StartCoroutine("Blinker");
    }
}
