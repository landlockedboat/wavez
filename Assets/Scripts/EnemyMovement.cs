using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    FollowPlayer followPlayer;
    LookAtPlayer lookAtPlayer;
    float stunDuration = 2;
	// Use this for initialization
	void Start () {
        followPlayer = GetComponent<FollowPlayer>();
        lookAtPlayer = GetComponentInChildren<LookAtPlayer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SendMessage("Stun", SendMessageOptions.DontRequireReceiver);
    }

    IEnumerator Stunned()
    {
        yield return new WaitForSeconds(stunDuration);
        followPlayer.ResumeBehaviour();
        lookAtPlayer.ResumeBehaviour();
    }

    public void Stun()
    {
        StopAllCoroutines();
        followPlayer.PauseBehaviour();
        lookAtPlayer.PauseBehaviour();
        StartCoroutine("Stunned");
    }
}
