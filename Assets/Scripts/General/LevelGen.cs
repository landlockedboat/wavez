using UnityEngine;

public class LevelGen : MonoBehaviour {
    [Header("Generation")]
    [SerializeField]
    GameObject[] enemies;

    [SerializeField]
    GameObject[] asteroids;
    [SerializeField]
    float asteroidsMinScale = 1f;
    [SerializeField]
    float asteroidsMaxScale = 20f;

    [SerializeField]
    float genRadius = 5f;
    [SerializeField]
    float genDist = 10f;
    [SerializeField]
    float genOffset = 2f;
    [SerializeField]
    int enemiesAmmount = 2;
    [SerializeField]
    int asteroidsAmmount = 3;
    [SerializeField]
    float minSpawnTime = 1f;
    [Header("B0ss")]
    [SerializeField]
    int spawnsTillBoss = 3;
    [SerializeField]
    GameObject b0ss;

    Vector2 prevSpawn;
    float currentX;
    float currentY;

    void Start () {
        prevSpawn = transform.position;
        Spawn();
        InvokeRepeating("CheckSpawn", minSpawnTime, minSpawnTime);
    }

    Vector2 GenerateRandomPos()
    {
        float randx = Random.Range(-(genOffset / 2), genOffset / 2);
        float sumx = currentX + randx;

        randx = randx < 0 ? sumx - genRadius / 2 : sumx + genRadius / 2;

        float randy = Random.Range(-(genOffset / 2), genOffset / 2);
        float sumy = currentY + randy;
        randy = randy < 0 ? sumy - genRadius / 2 : sumy + genRadius / 2;

        return new Vector2(randx, randy);
    }

    void Spawn()
    {
        Debug.Log("Spawning things at " + transform.position);
        currentX = transform.position.x;
        currentY = transform.position.y;
        for (int i = 0; i < enemiesAmmount; i++)
        {
            Vector2 pos = GenerateRandomPos();
            int type = Random.Range(0, enemies.Length);
            SpawnEnemyTypeAt(pos, type);
        }

        for (int i = 0; i < asteroidsAmmount; i++)
        {
            Vector2 pos = GenerateRandomPos();
            int type = Random.Range(0, asteroids.Length);
            SpawnAsteroidTypeAt(pos, type);
        }
    }

    void SpawnBoss()
    {
        currentX = transform.position.x;
        currentY = transform.position.y;
        Vector2 pos = GenerateRandomPos();
        GameObject bossObj = Instantiate(b0ss, pos, Quaternion.identity);
        BossIndicator.Instance.Activate(bossObj.transform);
    }

    void SpawnEnemyTypeAt(Vector2 pos, int type)
    {
        Instantiate(enemies[type], pos, Quaternion.identity);
    }

    void SpawnAsteroidTypeAt(Vector2 pos, int type)
    {
        GameObject go = Instantiate(asteroids[type], pos, Random.rotation);
        go.transform.localScale *= Random.Range(asteroidsMinScale, asteroidsMaxScale);
    }

    void CheckSpawn()
    {
        if(Vector2.Distance(transform.position, prevSpawn) > genDist)
        {
            prevSpawn = transform.position;
            --spawnsTillBoss;
            if (spawnsTillBoss <= 0)
            {
                SpawnBoss();
                spawnsTillBoss = 100;
            }
                
            Spawn();
        }
    }
}
