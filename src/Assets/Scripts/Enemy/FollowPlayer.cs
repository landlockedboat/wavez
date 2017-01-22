using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    [SerializeField]
    float speed = 5;
    [SerializeField]
    float maxSpeed = 10;
    float startingSpeed;
    [SerializeField]
    float speedInc = 2;
    bool paused = false;
    [SerializeField]
    float stoppingDist = 20f;

    private void Awake()
    {
        startingSpeed = speed;
    }

	void Update () {
        if (paused)
            return;
        Vector2 playerPos = PlayerController.Instance.PlayerPos;
        if (Vector2.Distance(transform.position, playerPos) <= stoppingDist)
            return;
        speed += speedInc * Time.deltaTime;
        if (speed > maxSpeed)
            speed = maxSpeed;
        transform.position = Vector2.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
    }

    public void PauseBehaviour()
    {
        paused = true;
        speed = startingSpeed;
    }

    public void ResumeBehaviour()
    {
        paused = false;
    }


}
