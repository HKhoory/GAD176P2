using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackholeSpawnMsg : ObstacleSpawnMsg
{
    public override void SpawnMessage()
    {
        Debug.Log("A blackhole has appeared, dodge it");
    }
}
