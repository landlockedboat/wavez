using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthManager {

    bool ded = false;

	public void Stun()
    {
        DecrementHealth();
    }

    public void Kill()
    {
        if (ded)
            return;
        ded = true;
        PlayerController.Instance.SendMessage("AddLife", SendMessageOptions.DontRequireReceiver);
    }
}
