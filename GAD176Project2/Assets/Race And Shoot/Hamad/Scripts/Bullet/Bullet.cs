using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    /// <summary>
    /// Basic mechanics for the bullet
    /// Gets the values for the bullet scriptable object and sets those values to the bullets speed and lifetime
    /// </summary>
    

    [SerializeField] public BulletScriptable test; //bullet scriptable object
    [SerializeField] private Rigidbody2D _rb2D;
    float speed;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        speed = test.speed;
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


}
