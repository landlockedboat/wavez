using System.Collections;
using UnityEngine;

public class BulletLogic : MonoBehaviour {
    new Rigidbody rigidbody;
    // Use this for initialization
    bool collided = false;
    float bulletTime;

	public void Init () {        
        rigidbody = GetComponent<Rigidbody>();
        bulletTime = 1;
        rigidbody.AddForce(transform.right * Shooting.Instance.CurrentBulletForce);
        StartCoroutine("Explode");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collided)
            return;
        collision.gameObject.SendMessage("Stun", SendMessageOptions.DontRequireReceiver);
        collided = true;
        rigidbody.velocity *= 0;
    }

    IEnumerator Explode()
    {
        yield return new WaitForSeconds(bulletTime);
        EmpController.Instance.NewEmp("Stun", transform.position, Shooting.Instance.EmpForce,
            Shooting.Instance.EmpRadius);
        CameraShake.Instance.ShakeIt(.3f, .75f);
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
