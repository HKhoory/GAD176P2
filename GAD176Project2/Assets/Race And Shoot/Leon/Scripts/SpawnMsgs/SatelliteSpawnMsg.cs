using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteSpawnMsg : ObstacleSpawnMsg
{
    public override void SpawnMessage()
    {
        Debug.Log("A satellite flew from the nearby spaceship");
    }
}
