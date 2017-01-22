using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUI : MonoBehaviour {

    RectTransform rt;
    [SerializeField]
    float maxFill = 350;
    [SerializeField]
    float minFill = 0;

    PlayerHealth ph;
    int maxHealth;

    void Start()
    {
        rt = GetComponent<RectTransform>();
        ph = PlayerController.Instance.gameObject.GetComponent<PlayerHealth>();
        maxHealth = ph.MaxHealth;
    }


    void Update()
    {
        float currHealth = ph.CurrentHealth;
        float fill = currHealth / maxHealth;
        float width = fill * (maxFill - minFill);
        rt.sizeDelta = new Vector2(width, rt.sizeDelta.y);

    }
}
