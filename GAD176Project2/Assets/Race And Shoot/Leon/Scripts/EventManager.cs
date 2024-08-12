using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public Obstacles obstacles;

    void OnEnable()
    {
        Obstacles.SpawnTimerEvent += ObstacleSpawner;

    }


    void OnDisable()
    {
        Obstacles.SpawnTimerEvent -= ObstacleSpawner;
    }


   void ObstacleSpawner()
    {
        Debug.Log("It works");
        /* obstacles.ItemSpawner = UnityEngine.Random.Range(0, 4);
        obstacles.startingSpawnTimer = 0f;
        if (obstacles.ItemSpawner == 1)
        {
            Instantiate(BlackHole, Vector2.zero, Quaternion.identity);
            //SpawnTime += Time.deltaTime;
            Destroy(BlackHole, 10f);
        }
        if (obstacles.ItemSpawner == 2)
        {
            Instantiate(Asteroids, Vector2.zero, Quaternion.identity);
            //SpawnTime += Time.deltaTime;
            Destroy(Asteroids, 10f);
        }
        if (obstacles.ItemSpawner == 3)
        {
            Instantiate(Satellite, Vector2.zero, Quaternion.identity);
            //SpawnTime += Time.deltaTime;
            Destroy(Satellite, 10f);
        }*/
    }
}
