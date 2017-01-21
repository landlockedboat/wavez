using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour {
    [Header("Generation")]
    [SerializeField]
    GameObject enemyPrefab;
    [SerializeField]
    GameObject[] asteroids;
    [SerializeField]
    float genRadius = 5f;
    [SerializeField]
    float genOffset = 2f;
    [SerializeField]
    int enemiesAmmount = 2;
    [SerializeField]
    int asteroidsAmmount = 3;
    [SerializeField]
    float minSpawnTime = 1f;

    Vector2 prevSpawn;

	// Use this for initialization
	void Start () {
        prevSpawn = transform.position;
        Spawn();
        InvokeRepeating("CheckSpawn", minSpawnTime, minSpawnTime);
    }

    void Spawn()
    {
        Debug.Log("Spawning things at " + transform.position);
        float xPos = transform.position.x;
        float yPos = transform.position.y;
        for (int i = 0; i < enemiesAmmount; i++)
        {
            float randx = Random.Range(-(genOffset/2), genOffset/2);
            float posxrand = xPos + randx;
            float posx = randx < 0 ? posxrand - genRadius / 2 : posxrand + genRadius/2;

            float randy = Random.Range(-(genOffset / 2), genOffset / 2);
            float posyrand = yPos + randy;
            float posy = randy < 0 ? posyrand - genRadius / 2 : posyrand + genRadius / 2;

            SpawnEnemyAt(new Vector2(posx, posy));
        }

        for (int i = 0; i < asteroidsAmmount; i++)
        {
            float randx = Random.Range(-(genOffset / 2), genOffset / 2);
            float posxrand = xPos + randx;
            float posx = randx < 0 ? posxrand - genRadius / 2 : posxrand + genRadius / 2;

            float randy = Random.Range(-(genOffset / 2), genOffset / 2);
            float posyrand = yPos + randy;
            float posy = randy < 0 ? posyrand - genRadius / 2 : posyrand + genRadius / 2;

            int type = Random.Range(0, asteroids.Length);

            SpawnAsteroidTypeAt(new Vector2(posx, posy), type);
        }
    }

    void SpawnEnemyAt(Vector2 pos)
    {
        Instantiate(enemyPrefab, pos, Quaternion.identity);
    }

    void SpawnAsteroidTypeAt(Vector2 pos, int type)
    {
        Instantiate(asteroids[type], pos, Quaternion.identity);
    }

    void CheckSpawn()
    {
        if(Vector2.Distance(transform.position, prevSpawn) > genRadius * 2)
        {
            prevSpawn = transform.position;
            Spawn();
        }
    }
}
