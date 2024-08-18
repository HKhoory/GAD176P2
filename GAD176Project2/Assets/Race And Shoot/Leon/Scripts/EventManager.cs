using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public Player playerscript;

    [SerializeField] GameObject player; 

    private Vector2 ObstacleSpawnPoint;

    public Obstacles obstacles;

    [SerializeField] ObstaclePrefabs AsteroidPrefabs;
    [SerializeField] ObstaclePrefabs SatellitePrefabs;
    [SerializeField] ObstaclePrefabs BlackHolePrefabs;

    [SerializeField] private float sphereCastRadius = 5.0f;
    private Ray ray;
    private RaycastHit Hit;

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
        obstacles.ItemSpawner = UnityEngine.Random.Range(0, 4);
        obstacles.startingSpawnTimer = 0f;
        if (obstacles.ItemSpawner == 1)
        {
            Blackhole();
        }
        if (obstacles.ItemSpawner == 2)
        {
            Asteroids();
        }
        if (obstacles.ItemSpawner == 3)
        {
            Satellite();
        }
    }

    public void Blackhole()
    {
        Instantiate(BlackHolePrefabs.GameObject(), ObstacleSpawnPoint, Quaternion.identity);
        Destroy(BlackHolePrefabs.GameObject(), 10f);

        if (Physics.SphereCast(ray,sphereCastRadius, out Hit))
        {
            Player.health--;
        }
        
    }
    
    public void Asteroids()
    {
        Instantiate(AsteroidPrefabs.GameObject(), ObstacleSpawnPoint, Quaternion.identity);
        Destroy(AsteroidPrefabs.GameObject(), 10f);

        
    }

    public void Satellite()
    {
        Instantiate(SatellitePrefabs.GameObject(), ObstacleSpawnPoint, Quaternion.identity);
        Destroy(SatellitePrefabs.GameObject(), 10f);
    }
}
