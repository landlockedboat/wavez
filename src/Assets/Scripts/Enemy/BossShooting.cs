using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : EnemyShooting {

	protected override void Shoot () {
        foreach (Transform tra in muzzles)
        {
            float angleDeg = Utilts.GetAngleBetween(tra.position, tra.parent.position);
            Quaternion bulletRot = Quaternion.Euler(angleDeg + 180, -90, 0);

            GameObject bull = Instantiate(bulletPrefab, tra.position, bulletRot)
                as GameObject;

            EnemyBulletLogic ebl = bull.GetComponent<EnemyBulletLogic>();
            ebl.Init(bulletSpeed, empRadius, empForce);
        }
    }
}
