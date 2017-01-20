using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    float empForce = 50f;
    [SerializeField]
    float empRadius = 30f;

    void Start()
    {
        MouseInputController.Instance.RegisterOnLeftMouseClickListener(Shoot);
    }

    void Shoot()
    {
        Vector2 empPos = MouseInputController.Instance.GetMouseScreenCoords();
        EmpController.Instance.NewEmp(empPos, empForce, empRadius);
    }

    void Update () {
        
    }
}
