using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Shield1;
    [SerializeField] private GameObject Shield2;
    [SerializeField] private GameObject Shield3;
    [SerializeField] private float rotationSpeed;


    // Start is called before the first frame update
    void Start()
    {

        Player = GameObject.Find("Player");
        Shield1.SetActive(false);
        Shield2.SetActive(false);
        Shield3.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Player.transform.position;
        transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));
        /*

        if (Shield1.activeSelf)
        {

        }
        else if (Shield2.activeSelf)
        {

        }
        else if (Shield3.activeSelf)
        {

        }
        else
        {
            Debug.Log("All Shields are active")''
        }

        */


    }
}
