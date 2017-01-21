using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {
    [SerializeField]
    float reloadTime = 1f;
    [SerializeField]
    float minShootingDist = 10f;
    float currentReloadTime = 0f;
    [Header("Bullet")]
    [SerializeField]
    float empRadius = 5f;
    [SerializeField]
    float empForce = 300f;
    [SerializeField]
    float bulletSpeed = 10f;

    [SerializeField]
    Transform muzzle;
    [SerializeField]
    GameObject bulletPrefab;

    bool isPaused = false;

    public void PauseShooting()
    {
        isPaused = true;
    }

    public void ResumeShooting()
    {
        isPaused = false;
    }

    void Shoot()
    {
        GameObject bull = Instantiate(bulletPrefab, muzzle.position, transform.rotation) 
            as GameObject;
        EnemyBulletLogic ebl = bull.GetComponent<EnemyBulletLogic>();
        ebl.Init(bulletSpeed, empRadius, empForce);
    }
	
	void Update () {
        if (isPaused)
            return;
        currentReloadTime += Time.deltaTime;
        if(currentReloadTime >= reloadTime)
        {
            Vector2 playerPos = PlayerController.Instance.PlayerPos;
            if(Vector2.Distance(transform.position, playerPos) <= minShootingDist)
                Shoot();
            currentReloadTime = 0;
        }
    }
}
