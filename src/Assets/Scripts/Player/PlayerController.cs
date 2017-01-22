using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController> {
    public Vector3 PlayerPos
    {
        get
        {
            return transform.position;
        }
    }
}
