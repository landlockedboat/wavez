using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    [SerializeField]
    int maxHealth = 2;
    int currentHealth;

    public int MaxHealth
    {
        get
        {
            return maxHealth;
        }
    }

    public int CurrentHealth
    {
        get
        {
            return currentHealth;
        }
    }

    // Use this for initialization
    void Awake () {
        currentHealth = maxHealth;
    }

    void Stun()
    {
        --currentHealth;
        if (currentHealth <= 0)
        {
            gameObject.SendMessage("Kill");
        }
            
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
