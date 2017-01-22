using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {
    [SerializeField]
    protected int maxHealth = 2;
    protected int currentHealth;

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

    protected void DecrementHealth()
    {
        --currentHealth;
        if (currentHealth <= 0)
        {
            gameObject.SendMessage("Kill", SendMessageOptions.DontRequireReceiver);
        }
    }
    protected void IncrementHealth(int ammount)
    {
        currentHealth += ammount;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
