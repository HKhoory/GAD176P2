using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public Player playerscript;

    [SerializeField] GameObject player;

    [SerializeField] GameObject quad;
    float screenX , screenY;
    Vector2 position;
    MeshCollider mesh;

    public Obstacles obstacles;

    [SerializeField] ObstaclePrefabs AsteroidPrefabs;
    [SerializeField] ObstaclePrefabs SatellitePrefabs;
    [SerializeField] ObstaclePrefabs BlackHolePrefabs;

    List<ObstacleSpawnMsg> SpawnMsg = new List<ObstacleSpawnMsg>();
    void Start()
    {
        SpawnMsg.Add(new BlackholeSpawnMsg());
        SpawnMsg.Add(new AsteroidSpawnMsg());
        SpawnMsg.Add(new SatelliteSpawnMsg());
    }
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
        screenX = Random.Range(mesh.bounds.min.x, mesh.bounds.max.x);
        screenY = Random.Range(mesh.bounds.min.y, mesh.bounds.max.y);
        position = new Vector2 (screenX, screenY);

        Instantiate(BlackHolePrefabs.GameObject(), position, Quaternion.identity);
        SpawnMsg[0].SpawnMessage();
        Destroy(BlackHolePrefabs.GameObject(), 3f);        
    }
    
    public void Asteroids()
    {
        screenY = Random.Range(mesh.bounds.min.y, mesh.bounds.max.y);
        position = new Vector2(3.5f, screenY);

        Instantiate(AsteroidPrefabs.GameObject(), position, Quaternion.identity);
        SpawnMsg[1].SpawnMessage();
        Destroy(AsteroidPrefabs.GameObject(), 10f);        
    }

    public void Satellite()
    {
        screenY = Random.Range(mesh.bounds.min.y, mesh.bounds.max.y);
        position = new Vector2(3.5f, screenY);

        Instantiate(SatellitePrefabs.GameObject(), position, Quaternion.identity);
        SpawnMsg[2].SpawnMessage();
        Destroy(SatellitePrefabs.GameObject(), 10f);
    }
}
