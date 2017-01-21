using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    FollowPlayer followPlayer;
    LookAtPlayer lookAtPlayer;
    
    void Awake () {
        followPlayer = GetComponent<FollowPlayer>();
        lookAtPlayer = GetComponentInChildren<LookAtPlayer>();
    }

    public void PauseMovement()
    {
        followPlayer.PauseBehaviour();
        lookAtPlayer.PauseBehaviour();
    }

    public void ResumeMovement()
    {
        followPlayer.ResumeBehaviour();
        lookAtPlayer.ResumeBehaviour();
    }
}
