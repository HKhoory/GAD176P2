using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blackhole : MonoBehaviour
{
    private GameObject player;
    
    void Awake()
    {
        //Finding the player script
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //If player is in the collider, its gets damaged
        if (player.gameObject.tag == "Player")
        {
            
            Player.health = -1;
        }
    }
}
