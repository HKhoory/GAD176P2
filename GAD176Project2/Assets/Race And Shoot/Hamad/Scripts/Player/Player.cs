using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


    public class Player : MonoBehaviour
    {

    /// <summary>
    /// Basic mechanics of the player
    /// Determines how the player moves
    /// </summary>


        [SerializeField] public float speed; //forward and backward speed
        [SerializeField] static public int health = 6; //health of the player
        [SerializeField] public float turnSpeed; //angular speed
        [SerializeField] private Rigidbody2D _rb2D; //rigidbody2D reference

    private int iHealth; //for use of the cooldown
    public UnityEvent testevent = new UnityEvent();
    public delegate void HitEnemy();
    public HitEnemy EnemyIsHit;


        void Start()
        {
            _rb2D.GetComponent<Rigidbody2D>(); //getting the rigidbody2D component of the player
        
        }

        void Update()
        {

            if (_rb2D == null) //if the rigidbody 2d reference isn't found
            {
                Debug.Log("ERROR: Player Doesn't have access to Rigidbody2D");
            return; //stops the program from running unless the rigidbody2d reference is found
            }

            MovePlayer(); //calls the function for moving the player
            TurnPlayer(); //calls the function for turning the player


            if (health <= 0) //if health is less than or equal to zero
            {
                DestroyPlayer(); //erase the player from the scene
            }


        }

        void MovePlayer() //moves the player forwards and backwards
        {

            float ySpeed = Input.GetAxis("Vertical"); //gets both keys W and S

            _rb2D.AddForce(this.transform.up * ySpeed * speed * Time.deltaTime); //accelerates the player using the speed value, depending on which button is pressed



        }

        void TurnPlayer()
        {

            float xSpeed = Input.GetAxis("Horizontal"); //gets both keys A and D

            _rb2D.AddTorque(xSpeed * turnSpeed * Time.deltaTime); //turns the player using the turnSpeed value, depending on which button is pressed



        }


        void DestroyPlayer() //destroys the player from the scene
        {

        Destroy(gameObject);

        }



    }
