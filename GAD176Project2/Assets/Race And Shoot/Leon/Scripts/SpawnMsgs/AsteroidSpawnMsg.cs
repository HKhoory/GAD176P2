using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawnMsg : ObstacleSpawnMsg
{
    public override void SpawnMessage()
    {
        Debug.Log("An asteroid is nearby, destroy it for some health");
    }
}
