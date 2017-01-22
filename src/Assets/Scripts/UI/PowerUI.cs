using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PowerUI : MonoBehaviour {
    RectTransform rt;
    [SerializeField]
    Text text;

    [SerializeField]
    float maxFill = 350;
    [SerializeField]
    float minFill = 0;

    [SerializeField]
    float blinkTime;

    Shooting ps;
    float maxForce;
    bool isBlinking = false;

	void Start () {
        rt = GetComponent<RectTransform>();
        ps = Shooting.Instance;
        maxForce = ps.MaxBulletForce;
    }

    IEnumerator Blink()
    {
        Color noAlpha = text.color;
        noAlpha.a = 0;
        text.color = noAlpha;
        yield return new WaitForSeconds(blinkTime);
        Color alpha = text.color;
        alpha.a = 1;
        text.color = alpha;
        yield return new WaitForSeconds(blinkTime);
        if (!ps.Reloading)
        {
            isBlinking = false;
        }
        else
            StartCoroutine("Blink");
    }
	
	// Update is called once per frame
	void Update () {
        if (isBlinking)
            return;
        float currForce = ps.CurrentBulletForce;
        float fill = currForce / maxForce;
        float width = fill * (maxFill - minFill);
        rt.sizeDelta = new Vector2(width, rt.sizeDelta.y);
        if (ps.Reloading)
        {
            isBlinking = true;
            StartCoroutine("Blink");
        }            
    }
}
