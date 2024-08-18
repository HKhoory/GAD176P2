using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnMsg
{
    public virtual void SpawnMessage()
    {
        Debug.Log("An Obstacle has spawned");
    }
}
