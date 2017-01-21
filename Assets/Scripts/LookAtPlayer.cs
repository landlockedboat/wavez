using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

    bool paused = false;
    [SerializeField]
    float angSpeed = 6f;
	
	void Update () {
        if (paused)
            return;
        Vector2 playerPos = PlayerController.Instance.PlayerPos;
        Vector2 fwd = transform.position + transform.forward;

        Vector2 lookPos = Vector2.MoveTowards(fwd, playerPos, angSpeed * Time.deltaTime);

        transform.LookAt(lookPos);
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
