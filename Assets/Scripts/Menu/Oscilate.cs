using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilate : MonoBehaviour {
    bool toDown = true;
    [SerializeField]
    float descent = 1;
    [SerializeField]
    float speed = 2;
    float minHeight, maxHeight;
    [SerializeField]
    float delay = 0;
    bool active = false;

	void OnEnable () {
        Invoke("Activate", delay);
    }

    void Activate()
    {
        minHeight = transform.position.y - descent;
        maxHeight = transform.position.y;
        active = true;
    }
	
	void Update () {
        if (!active)
            return;
        if (toDown)
        {
            transform.position -= -transform.forward * speed * Time.deltaTime;
            if(transform.position.y <= minHeight)
            {
                transform.position = new Vector3(transform.position.x
                    , minHeight, transform.position.z);
                toDown = false;
            }
        }
        else
        {
            transform.position += -transform.forward * speed * Time.deltaTime;
            if (transform.position.y >= maxHeight)
            {
                transform.position = new Vector3(transform.position.x
                    , maxHeight, transform.position.z);
                toDown = true;
            }
        }
	}
}
