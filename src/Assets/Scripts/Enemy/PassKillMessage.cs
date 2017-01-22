using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassKillMessage : MonoBehaviour {

	public void Kill()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).SendMessage("Kill", SendMessageOptions.DontRequireReceiver);
        }
    }
}
