using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void Move()
    {
        Debug.Log("Enemy is moving");
    }

    protected virtual void Shoot()
    {
        Debug.Log("Enemy is shooting");
    }

    protected virtual void Destroy()
    {
        //destroy the enemy gameobject
    }

}
