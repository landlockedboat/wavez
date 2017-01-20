using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    [SerializeField]
    float speed = 5;

	void Update () {
        Vector2 playerPos = PlayerController.Instance.PlayerPos;
        transform.LookAt(playerPos);
        transform.position = Vector2.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
    }
}
