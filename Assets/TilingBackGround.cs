using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilingBackGround : MonoBehaviour {

    Vector3 lastPos;
    [SerializeField]
    GameObject bgPrefab;
    [SerializeField]
    float bgSize = 20;

    List<GameObject> backs;

	void Start () {
        backs = new List<GameObject>();
        lastPos = transform.position;
        CreateBG();
    }

    void CreateBG()
    {
        foreach(GameObject obj in backs)
        {
            Destroy(obj);
        }
        backs = new List<GameObject>();

        lastPos.z = 1;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));
        lastPos.x += bgSize;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));
        lastPos.x -= bgSize * 2;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));
        lastPos.x += bgSize;
        lastPos.y += bgSize;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));
        lastPos.y -= bgSize * 2;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));
        lastPos.y += bgSize;
    }
	
	void Update () {
		if(lastPos.x - transform.position.x > bgSize/2)
        {
            lastPos.x -= bgSize;
            CreateBG();
        }
        if (lastPos.x - transform.position.x < -bgSize/2)
        {
            lastPos.x += bgSize;
            CreateBG();
        }
        if (lastPos.y - transform.position.y > bgSize/2)
        {
            lastPos.x -= bgSize;
            CreateBG();
        }
        if (lastPos.y - transform.position.y < -bgSize/2)
        {
            lastPos.y += bgSize;
            CreateBG();
        }
    }
}
