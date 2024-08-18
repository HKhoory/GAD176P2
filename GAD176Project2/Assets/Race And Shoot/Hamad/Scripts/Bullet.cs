using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    //get the scriptable object


    

    [SerializeField] public BulletScriptable test;
    [SerializeField] private Rigidbody2D _rb2D;
    float speed;
    float size;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        speed = test.speed;
        size = test.size;
        time = test.timer;
        _rb2D.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        _rb2D.AddForce(transform.up * speed, ForceMode2D.Impulse);

        time -= Time.deltaTime;

        if (time <= 0f)
        {
            Destroy(gameObject);
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
