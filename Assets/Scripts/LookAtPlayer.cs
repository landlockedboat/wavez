using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

    bool paused = false;
	
	void Update () {
        if (paused)
            return;
        Vector2 playerPos = PlayerController.Instance.PlayerPos;
        transform.LookAt(playerPos);
	}

    public void PauseBehaviour()
    {
        paused = true;
    }

    public void ResumeBehaviour()
    {
        paused = false;
    }
}
