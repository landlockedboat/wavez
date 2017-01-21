using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitiesController : Singleton<EntitiesController> {
    [SerializeField]
    float enemyBulletsTimeToLive = 5f;

    public float EnemyBulletsTimeToLive
    {
        get
        {
            return enemyBulletsTimeToLive;
        }

    }
}
