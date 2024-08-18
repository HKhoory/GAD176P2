using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : BaseEnemy
{

    [SerializeField] private float speed;
    [SerializeField] private float health;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float maxVelocity;
    [SerializeField] private GameObject player;
    [SerializeField] private Rigidbody2D _rb2D;

    //slowly face the player as it moves in an ice-rink behavior

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        _rb2D.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (player == null)
        {
            Debug.Log("Player refernce not found");
            return;
        }


        Move();

    }

    public override void Move()
    {
        var currentVelocity = _rb2D.velocity;
        Vector2 target;
        target = player.transform.position - transform.position;

        _rb2D.AddForce(new Vector2(target.x * speed, target.y * speed));

        if (_rb2D.velocity.magnitude >= maxVelocity)
        {
            _rb2D.velocity = currentVelocity.normalized * maxVelocity;
        }
    }



}
