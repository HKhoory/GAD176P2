using System.Collections;
using System.Collections.Generic;
using System.Resources;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class ObstacleManager : MonoBehaviour
{
    MeshCollider meshCollider;
    float screenX, screenY;
    Vector2 position;
    [SerializeField] GameObject quad;

    public Player playerscript;

    [SerializeField] GameObject player; 

    public Obstacles obstacles;

    [SerializeField] ObstaclePrefabs AsteroidPrefabs;
    [SerializeField] ObstaclePrefabs SatellitePrefabs;
    [SerializeField] ObstaclePrefabs BlackHolePrefabs;

    [SerializeField] Blackhole blackhole;
    [SerializeField] Asteroid asteroid;
    [SerializeField] Satellite satellite;

    List<ObstacleSpawnMsg> obstaclesmsg = new List<ObstacleSpawnMsg>();

    void Start()
    {
        obstaclesmsg.Add(new BlackholeSpawnMsg());
        obstaclesmsg.Add(new AsteroidSpawnMsg());
        obstaclesmsg.Add(new SatelliteSpawnMsg());
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
        meshCollider = quad.GetComponent<MeshCollider>();
        screenX = Random.Range(meshCollider.bounds.min.x, meshCollider.bounds.max.x);
        screenY = Random.Range(meshCollider.bounds.min.y, meshCollider.bounds.max.y);
        position = new Vector2(screenX, screenY);

        Instantiate(BlackHolePrefabs.GameObject(), position, Quaternion.identity);
        obstaclesmsg[0].SpawnMessage();
        Destroy(BlackHolePrefabs.GameObject(), 3f);
    }

    public void Asteroids()
    {
        meshCollider = quad.GetComponent<MeshCollider>();
        screenY = Random.Range(meshCollider.bounds.min.y, meshCollider.bounds.max.y);
        position = new Vector2(3.5f, screenY);

        Instantiate(AsteroidPrefabs.GameObject(), position, Quaternion.identity);
        obstaclesmsg[0].SpawnMessage();
        Destroy(AsteroidPrefabs.GameObject(), 10f);
    }

    public void Satellite()
    {
        meshCollider = quad.GetComponent<MeshCollider>();
        screenX = Random.Range(meshCollider.bounds.min.x, meshCollider.bounds.max.x);
        screenY = Random.Range(meshCollider.bounds.min.y, meshCollider.bounds.max.y);
        position = new Vector2(screenX, screenY);

        Instantiate(SatellitePrefabs.GameObject(), position, Quaternion.identity);
        obstaclesmsg[0].SpawnMessage();
        Destroy(SatellitePrefabs.GameObject(), 10f);
    }      
}
