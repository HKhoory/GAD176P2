using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Turret : MonoBehaviour
{

    [SerializeField] private GameObject[] bullets;
    [SerializeField] private float cooldownTimer;
    

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = cooldownTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; //calculating transform direction from mouse cursor to center

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);


        if (Input.GetMouseButton(0) && timer <= 0f)
        {
            //shoot bullet
            var bullet = Instantiate(bullets[0], transform.position, transform.rotation);
            timer = cooldownTimer;
        }
    }
}
