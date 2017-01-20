using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : Singleton<PhysicsController> {

    public List<GameObject> physicsObjects { get; protected set; }

    public void AddPhysicsObject(GameObject obj)
    {
        if(physicsObjects == null)
        {
            physicsObjects = new List<GameObject>();
        }
        physicsObjects.Add(obj);
    }

    public void RemovePhysicsObject(GameObject obj)
    {
        physicsObjects.Remove(obj);
    }    
}
