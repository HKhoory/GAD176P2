using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public Event ObstacleSpawner;

    public GameObject BlackHole;
    public GameObject Satellite;
    public GameObject Asteroids;

    float SpawnerTimer;
    //float SpawnTime;

    public int ItemSpawner; 
    
    void Start()
    {
        
    }

    void Update()
    {
        SpawnerTimer += Time.deltaTime;
        if (SpawnerTimer > 10f)
        {
            ItemSpawner = Random.Range(1, 4);
            SpawnerTimer = 0f;
            if (ItemSpawner == 1) 
            {
                Instantiate(BlackHole, Vector2.zero, Quaternion.identity);
                //SpawnTime += Time.deltaTime;
                Destroy(BlackHole, 10f);
            }
            if (ItemSpawner == 2)
            {
                Instantiate(Asteroids, Vector2.zero, Quaternion.identity);
                //SpawnTime += Time.deltaTime;
                Destroy(Asteroids, 10f);
            }
            if (ItemSpawner == 3)
            {
                Instantiate(Satellite, Vector2.zero, Quaternion.identity);
                //SpawnTime += Time.deltaTime;
                Destroy(Satellite, 10f);
            }
        }
    }
}
