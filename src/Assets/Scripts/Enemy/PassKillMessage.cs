using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassKillMessage : MonoBehaviour {
    [SerializeField]
    GameObject cannons;

	public void Kill()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).SendMessage("Kill", SendMessageOptions.DontRequireReceiver);
        }
        gameObject.SendMessage("PauseShooting", SendMessageOptions.DontRequireReceiver);
        for (int i = 0; i < cannons.transform.childCount; i++)
        {
            cannons.transform.GetChild(i).
                SendMessage("Kill", SendMessageOptions.DontRequireReceiver);
        }
    }
}
