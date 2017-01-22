using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySuperShooting : EnemyShooting {

	protected override void Shoot () {
        foreach (Transform tra in muzzles)
        {
            Vector2 bulletPos = tra.position;
            Vector2 actPos = transform.position;

            float AngleRad = Mathf.Atan2(bulletPos.y - actPos.y, bulletPos.x - actPos.x);
            float AngleDeg = (180 / Mathf.PI) * AngleRad;

            Quaternion bulletRot = Quaternion.Euler(AngleDeg + 180, -90, 0);

            GameObject bull = Instantiate(bulletPrefab, tra.position, bulletRot)
                as GameObject;

            EnemyBulletLogic ebl = bull.GetComponent<EnemyBulletLogic>();
            ebl.Init(bulletSpeed, empRadius, empForce);
        }
    }
	
}
