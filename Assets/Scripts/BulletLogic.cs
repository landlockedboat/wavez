using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour {
    new Rigidbody rigidbody;
    // Use this for initialization
    bool collided = false;
	void Start () {        
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.right * Shooting.Instance.BulletForce);
        StartCoroutine("Explode");
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SendMessage("Stun", SendMessageOptions.DontRequireReceiver);
        if (collided)
            return;
        collided = true;
        rigidbody.velocity *= 0;
    }

    IEnumerator Explode()
    {
        yield return new WaitForSeconds(Shooting.Instance.BulletTime);
        EmpController.Instance.NewEmp(transform.position, Shooting.Instance.EmpForce,
            Shooting.Instance.EmpRadius);
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
