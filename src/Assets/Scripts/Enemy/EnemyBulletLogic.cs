using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletLogic : MonoBehaviour {

    float bulletSpeed, empRadius, empForce;
    bool isInitialised = false;
    [SerializeField]
    float timeToLive = 5f;

    public void Init(float _bulletSpeed, float _empRadius, float _empForce)
    {
        bulletSpeed = _bulletSpeed;
        empRadius = _empRadius;
        empForce = _empForce;
        isInitialised = true;
        StartCoroutine("Destroy");
    }


    void Update()
    {
        if (!isInitialised)
            return;
        transform.position = transform.position + (transform.forward * (bulletSpeed * Time.deltaTime));
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(timeToLive);
        Explode();
        
    }

    void Explode()
    {
        EmpController.Instance.NewEmp("EnemyEmp", transform.position, empForce, empRadius);
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        Explode();
    }
}
