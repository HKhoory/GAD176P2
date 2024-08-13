using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Bullet", menuName = "Bullet/Bullet Type", order = 1)]
public class BulletScriptable : ScriptableObject
{

    public float speed;
    public float size;
    public float timer;


}
