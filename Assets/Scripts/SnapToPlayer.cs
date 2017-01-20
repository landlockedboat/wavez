using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToPlayer : MonoBehaviour {
    [SerializeField]
    float fixedz;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPos = PlayerController.Instance.PlayerPos;
        transform.position = new Vector3(playerPos.x, playerPos.y, fixedz);

    }
}
