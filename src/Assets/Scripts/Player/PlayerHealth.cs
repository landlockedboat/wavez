using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthManager {
    [SerializeField]
    GameObject cannon;
    [SerializeField]
    GameObject dedText;
    [SerializeField]
    int lifeHealed = 1;
	public void EnemyEmp()
    {
        DecrementHealth();
        CameraShake.Instance.ShakeIt(.5f, .5f);
    }

    public void Kill()
    {
        cannon.SendMessage("Kill");
        dedText.SetActive(true);
        BossIndicator.Instance.Deactivate();
    }

    public void AddLife()
    {
        IncrementHealth(lifeHealed);
    }
}
