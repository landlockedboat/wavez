using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilingBackGround : MonoBehaviour {

    Vector3 lastPos;
    [SerializeField]
    GameObject bgPrefab;
    [SerializeField]
    float bgSize = 20;
    [SerializeField]
    float bgDepth = 10;

    List<GameObject> backs;

	void Start () {
        backs = new List<GameObject>();
        lastPos = transform.position;
        CreateBG();
    }

    void CreateBG()
    {
        Debug.Log("Creating BG's at " + lastPos);
        foreach(GameObject obj in backs)
        {
            Destroy(obj);
        }
        backs = new List<GameObject>();

        lastPos.z = bgDepth;        
        //top-right
        lastPos.y += bgSize;
        lastPos.x += bgSize;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));
        //right
        lastPos.y -= bgSize;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));
        //bot-right
        lastPos.y -= bgSize;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));
        
        //bot
        lastPos.x -= bgSize;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));

        //bot-left
        lastPos.x -= bgSize;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));
        //left
        lastPos.y += bgSize;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));
        //top-left
        lastPos.y += bgSize;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));

        //top
        lastPos.x += bgSize;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));

        //center
        lastPos.y -= bgSize;
        backs.Add(Instantiate(bgPrefab, lastPos, Quaternion.identity));
    }
	
	void Update () {

		if(lastPos.x - transform.position.x >= bgSize/2)
        {
            lastPos.x -= bgSize;
            CreateBG();
        }
        else if (lastPos.x - transform.position.x <= -bgSize/2)
        {
            lastPos.x += bgSize;
            CreateBG();
        }
        else if(lastPos.y - transform.position.y >= bgSize/2)
        {
            lastPos.y -= bgSize;
            CreateBG();
        }
        else if(lastPos.y - transform.position.y <= -bgSize/2)
        {
            lastPos.y += bgSize;
            CreateBG();
        }
    }
}
