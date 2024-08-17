using System;
using UnityEngine;
using static Obstacles;

public class Obstacles : MonoBehaviour
{
    bool timerReached = false;
    public int ItemSpawner;

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
        if (startingSpawnTimer > timeToSpawnAnItem)

        {

            if (SpawnTimerEvent != null)
            {
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
}

