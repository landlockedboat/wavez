using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpController : Singleton<EmpController> {

    [SerializeField]
    GameObject empPrefab;

    public void NewEmp(Vector2 origin, float force, float rad) {
        foreach (GameObject obj in PhysicsController.Instance.physicsObjects){

            Rigidbody rig = obj.GetComponent<Rigidbody>();

            if(rig == null) {
                Debug.LogError("PhysicsObject without Rigidbody. Are you sure?");
                continue;
            }

            Instantiate(empPrefab, origin, Quaternion.identity);
            rig.AddExplosionForce(force, origin, rad);
        }
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
