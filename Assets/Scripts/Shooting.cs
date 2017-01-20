using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shooting : Singleton<Shooting>
{
    [Header("EMP")]
    [SerializeField]
    float empForce = 50f;
    [SerializeField]
    float empRadius = 30f;
    [Header("Bullet")]
    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    float bulletTime = 3f;
    [SerializeField]
    float bulletForce = 200f;
    [Header("Shooting")]
    [SerializeField]
    float reloadTime = 1f;
    bool reloading = false;
    [Header("Turret")]
    [SerializeField]
    Transform muzzle;
    

    public float EmpForce
    {
        get
        {
            return empForce;
        }
    }

    public float EmpRadius
    {
        get
        {
            return empRadius;
        }
    }

    public float BulletTime
    {
        get
        {
            return bulletTime;
        }
    }

    public float BulletForce
    {
        get
        {
            return bulletForce;
        }
    }

    void Start()
    {
        MouseInputController.Instance.RegisterOnLeftMouseClickListener(Shoot);
    }

    void Shoot()
    {
        if (reloading)
            return;
        StopAllCoroutines();
        reloading = true;
        StartCoroutine("Reload");
        Vector2 empPos = MouseInputController.Instance.GetMouseScreenCoords();
        Instantiate(bulletPrefab, muzzle.position, transform.rotation);

        
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);
        reloading = false;
    }

    void Update () {
        
    }
}
