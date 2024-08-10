using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private int health;
    [SerializeField] private float turnSpeed;
    [SerializeField] private Rigidbody2D _rb2D;
    [SerializeField] private GameObject[] bullets;


    // Start is called before the first frame update
    void Start()
    {
        _rb2D.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (_rb2D == null)
        {
            Debug.Log("ERROR: Player Doesn't have access to Rigidbody2D");
        }

        MovePlayer();
        TurnPlayer();
        Shoot();


        if (health <= 0)
        {
            DestroyPlayer();
        }


    }

    void MovePlayer()
    {

        //float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");

        //_rb2D.velocity = new Vector2(_rb2D.velocity.x, ySpeed * speed * Time.deltaTime);
        _rb2D.AddForce(this.transform.up * ySpeed * speed * Time.deltaTime);

        

    }

    void TurnPlayer()
    {

        float xSpeed = Input.GetAxis("Horizontal");
        //float ySpeed = Input.GetAxis("Vertical");

        _rb2D.AddTorque(xSpeed * turnSpeed * Time.deltaTime);



    }

    void Shoot()
    {


    }


    void DestroyPlayer()
    {

        Destroy(gameObject);

    }



}
