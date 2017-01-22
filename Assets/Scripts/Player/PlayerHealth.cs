using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthManager {
    [SerializeField]
    GameObject cannon;
    [SerializeField]
    GameObject dedText;
	public void EnemyEmp()
    {
        DecrementHealth();
    }

    public void Kill()
    {
        cannon.SendMessage("Kill");
        dedText.SetActive(true);
        BossIndicator.Instance.Deactivate();
    }
}
