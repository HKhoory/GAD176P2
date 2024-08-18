using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private GameObject player;
    [SerializeField] Rigidbody rb;
    void Awake()
    {
        //Finding the player script and getting rigidbody component
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector2 (0.5f, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (player.gameObject.tag == "Player")
        {
            Destroy(player);
        }
        if (player.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            int extrahp = Random.Range(1, 4);
            if (extrahp == 1)
            {
                Player.health = +1;
            }
        }
    }
}
