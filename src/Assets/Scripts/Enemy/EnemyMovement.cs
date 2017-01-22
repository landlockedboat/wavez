using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    FollowPlayer followPlayer;
    
    void Awake () {
        followPlayer = GetComponent<FollowPlayer>();
    }

    public void PauseMovement()
    {
        followPlayer.PauseBehaviour();
    }

    public void ResumeMovement()
    {
        followPlayer.ResumeBehaviour();
    }
}
