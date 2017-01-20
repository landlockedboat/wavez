using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpController : Singleton<EmpController> {

    [SerializeField]
    GameObject empPrefab;

    public void NewEmp(Vector2 origin, float force, float rad) {
        foreach (GameObject obj in PhysicsController.Instance.physicsObjects){
            if(Vector2.Distance(origin, obj.transform.position) < rad)
                obj.SendMessage("Stun", SendMessageOptions.DontRequireReceiver);

            Rigidbody rig = obj.GetComponent<Rigidbody>();

            if(rig == null) {
                Debug.LogError("PhysicsObject without Rigidbody. Are you sure?");
                continue;
            }

            rig.AddExplosionForce(force, origin, rad);
        }
    }
}
