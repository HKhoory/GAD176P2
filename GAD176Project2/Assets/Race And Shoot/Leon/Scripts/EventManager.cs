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
        //Quad and meshcollider to check the size of the screen, which allows us to find a vector2 to spawn the blackhole on the screen
        mesh = quad.GetComponent<MeshCollider>();
        screenX = Random.Range(mesh.bounds.min.x, mesh.bounds.max.x);
        screenY = Random.Range(mesh.bounds.min.y, mesh.bounds.max.y);
        position = new Vector2 (screenX, screenY);

        //Spawns the object on the position with the spawnmsg on console
        Instantiate(BlackHolePrefabs.GameObject(), position, Quaternion.identity);
        SpawnMsg[0].SpawnMessage();
        //Destroys the object after 3 seconds
        Destroy(BlackHolePrefabs.GameObject(), 3f);        
    }
    
    public void Asteroids()
    {
        //Quad and meshcollider to check the size of the screen, which allows us to find a vector2 to spawn the blackhole on the screen
        mesh = quad.GetComponent<MeshCollider>();
        screenY = Random.Range(mesh.bounds.min.y, mesh.bounds.max.y);
        position = new Vector2(3.5f, screenY);

        //Spawns the object on the position with the spawnmsg on console
        Instantiate(AsteroidPrefabs.GameObject(), position, Quaternion.identity);
        SpawnMsg[1].SpawnMessage();
        //Destroys the object after 10 seconds
        Destroy(AsteroidPrefabs.GameObject(), 10f);        
    }

    public void Satellite()
    {
        //Quad and meshcollider to check the size of the screen, which allows us to find a vector2 to spawn the blackhole on the screen
        mesh = quad.GetComponent<MeshCollider>();
        screenY = Random.Range(mesh.bounds.min.y, mesh.bounds.max.y);
        position = new Vector2(3.5f, screenY);

        //Spawns the object on the position with the spawnmsg on console
        Instantiate(SatellitePrefabs.GameObject(), position, Quaternion.identity);
        SpawnMsg[2].SpawnMessage();
        //Destroys the object after 10 seconds
        Destroy(SatellitePrefabs.GameObject(), 10f);
    }
}
