using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour {
    [SerializeField]
    float stunDuration = 2;
    [SerializeField]
    EnemyMovement movement;
    [SerializeField]
    EnemyShooting shooting;
    [SerializeField]
    float velocityToStunOtherEnemy = 5f;


    Rigidbody rigidbdy;
    bool dead = false;

    private void Awake()
    {
        rigidbdy = GetComponent<Rigidbody>();
    }

    void PauseBehaviours()
    {
        movement.PauseMovement();
        shooting.PauseShooting();
    }

    void ResumeBehaviours()
    {
        movement.ResumeMovement();
        shooting.ResumeShooting();
    }

    public void Kill()
    {
        StopAllCoroutines();
        dead = true;
        for (int i = 0; i < transform.childCount; ++i){
            transform.GetChild(i).SendMessage("Kill", SendMessageOptions.DontRequireReceiver);
        }
        PauseBehaviours();
    }

    IEnumerator Stunned()
    {
        yield return new WaitForSeconds(stunDuration);
        ResumeBehaviours();
    }

    public void EnemyEmp()
    {
        Stun();
    }


    public void Stun()
    {
        if (dead)
            return;
        StopAllCoroutines();
        PauseBehaviours();
        StartCoroutine("Stunned");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(rigidbdy.velocity.magnitude >= velocityToStunOtherEnemy)
            collision.gameObject.SendMessage("Stun", SendMessageOptions.DontRequireReceiver);
    }
}
