using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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

    protected virtual void DestroyEnemy()
    {
        Destroy(gameObject);
    }

}
