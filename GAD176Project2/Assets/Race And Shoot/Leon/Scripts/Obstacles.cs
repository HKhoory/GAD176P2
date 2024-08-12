using System;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject BlackHole;
    public GameObject Satellite;
    public GameObject Asteroids;

    bool timerReached = false;
    int ItemSpawner;

    public float startingSpawnTimer = 0f;
    public float timeToSpawnAnItem = 20f;

    public delegate void OnSpawnTimer();
    public static event OnSpawnTimer SpawnTimerEvent;

    void Start()
    {

    }

    void Update()
    {

        startingSpawnTimer += Time.deltaTime;
        //Debug.Log(startingSpawnTimer);
        if (startingSpawnTimer > timeToSpawnAnItem)

        {

            if (SpawnTimerEvent != null)
            {
                Debug.Log("Its invoked");
                SpawnTimerEvent.Invoke();
            }
            timerReached = true;
        }
        
        if (timerReached == true)
        {
            startingSpawnTimer = 0f;
            timerReached = false;
        }
        
    }

    public void ObstacleSpawner()
    {
        ItemSpawner = UnityEngine.Random.Range(0, 4);
        startingSpawnTimer = 0f;
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
