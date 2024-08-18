using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour
{
    private GameObject player;
    [SerializeField] Rigidbody2D rb;
    void Awake()
    {
        //Finding the player script and getting rigidbody component
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //moves the gameobject left every frame
        rb.velocity = new Vector2(0.5f, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //If player shoots the satellite, the gameobject gets destroyed
        if (player.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
