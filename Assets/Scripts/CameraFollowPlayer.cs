using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour {
    [SerializeField]
    float cameraHeight = 1f;
    [SerializeField]
    float cameraSpeed = 3f;
    [SerializeField]
    float distFactor = 1f;
    Vector2 playerPos;

	// Update is called once per frame
	void Update () {
        playerPos = PlayerController.Instance.PlayerPos;
        float deltaPos = (Vector2.Distance(playerPos, transform.position) * distFactor +
            cameraSpeed) * Time.deltaTime;
        Vector2 rawPos = Vector2.MoveTowards(transform.position, playerPos, deltaPos);
        transform.position = new Vector3(rawPos.x, rawPos.y, cameraHeight);

    }
}
