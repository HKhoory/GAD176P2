using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    //get the scriptable object

    [SerializeField] public BulletScriptable test;
    float speed;
    float size;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        speed = test.speed;
        size = test.size;
        time = test.timer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
