using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GAD176.Hamad.Enemy
{
    public class Enemy1 : BaseEnemy
    {

        /// <summary>
        /// Basic mechanics from enemy type 1
        /// moves like it is in an ice rink
        /// has speed, health, turnSpeed, and maxVelocity has values
        /// has references for Player and Rigidbody2D
        /// </summary>

        [SerializeField] private float speed; //determines the speed of the enemy
        [SerializeField] private float health; //determines the health points of the enemy
        [SerializeField] private float maxVelocity; //velocity cap to prevent enemy from speeding up
        [SerializeField] private GameObject player; //player reference
        [SerializeField] private Rigidbody2D _rb2D; //rigidbody2D reference

        [SerializeField] private LayerMask layer; //layer for detecting player


        void Start()
        {
            player = GameObject.Find("Player"); //searches for player in the scene
            _rb2D.GetComponent<Rigidbody2D>(); //gets rigidbody2d component
        }

        // Update is called once per frame
        void Update()
        {

            if (player == null) //if player reference is missing
            {
                Debug.Log("Player refernce not found");
                return; //prints a debug message and prevents code from running
            }

            if (_rb2D == null) //if rigidbody 2d reference is missing
            {
                Debug.Log("Error: Rigidbody2D in enemy not found");
                return;//prints a debug message and prevents code from running
            }

            if (Physics2D.BoxCast(transform.position, new Vector2(1, 1), 0f, Vector2.up, Mathf.Infinity, layer)) //if boxcast collides with player
            {
                Player.health--; //decrease player's health
            }

            Move(); //runs the move function

            if (health <= 0)
            {
                DestroyEnemy(); //destroys the enemy if health is less than or equal to zero
            }

        }

        public override void Move() //overrides the move function from baseenemy
        {
            var currentVelocity = _rb2D.velocity; //gets reference to rigidbody 2d's velocity
            Vector2 target; //sets a target to follow
            target = player.transform.position - transform.position; //calculates distance between enemy and player

            _rb2D.AddForce(new Vector2(target.x * speed, target.y * speed)); //adds force on the enemy to accelerate it toward the player

            if (_rb2D.velocity.magnitude >= maxVelocity)
            {
                _rb2D.velocity = currentVelocity.normalized * maxVelocity; //if the velocity exceeds the maxVelocity, normalize the velocity back to the maxVelocity
            }
        }

        private void OnDrawGizmos() //for scene debugging
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(transform.position, new Vector3(1f, 1f, 1f)); //drawing a wire cube for debugging boxcast
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Bullet"))
            {
                health--; //if enemy collides with bullet, decrease enemy's health by 1
            }
        }


    }

}