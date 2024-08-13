using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class BoostPlayerSpeed : MonoBehaviour
{
    private bool boost;
    private float boostTimer;
    [SerializeField] float boostTimerLimit;
    [SerializeField] string otherColliderTag;
    Player player;
    BoxCollider2D box;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == otherColliderTag)
        {
            Debug.Log("player entered");
            boost = true;

            player = FindObjectOfType<Player>();

            if (player != null)
            {
                 //player.speed *= 2 ;
                 //player.turnSpeed *= 2;

                Debug.Log("boost activated");
            }
        }
    }

    void Start()
    {
        boost = false;

        box = GetComponent<BoxCollider2D>();
        box.isTrigger = true;
    }

    private void Update()
    {
        BoostTime();
    }

    void BoostTime()
    {
        if (boost)
        {
            boostTimer += Time.deltaTime;

            if(boostTimer >= boostTimerLimit)
            {
               //player.speed /= 2;
               //player.turnSpeed /= 2;
                boostTimer = 0;
                boost = false;
                Debug.Log("boost deactivated");
            }

        }
    }

    
    
}
