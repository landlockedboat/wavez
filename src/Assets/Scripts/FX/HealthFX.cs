using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFX : MonoBehaviour {
    [SerializeField]
    Color healthyCol;
    [SerializeField]
    Color unhealthyCol;
    [SerializeField]
    Color deadCol;
    bool ded = false;

    HealthManager eh;
    MeshRenderer rend;
    int maxHealth;
    int currHealth;
	// Use this for initialization
	void Awake() {
        eh = transform.root.GetComponent<HealthManager>();
        rend = GetComponent<MeshRenderer>();
        maxHealth = eh.MaxHealth;
    }
	
	// Update is called once per frame
	void Update () {
        if (ded)
            return;
        currHealth = eh.CurrentHealth;            
        float amm = 1 - (float)currHealth / maxHealth;
        rend.material.color = Color.Lerp(healthyCol, unhealthyCol, amm);

        if (currHealth <= 0)
        {
            rend.material.color = deadCol;
            ded = true;
        }
    }
}
