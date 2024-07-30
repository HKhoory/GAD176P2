using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class SlowPlayerDown : MonoBehaviour
{

    [SerializeField] string otherColliderTag;
    [SerializeField] float speedReduction;
    Player player;
    BoxCollider2D box;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == otherColliderTag)
        {
            Debug.Log("player entered");
            ReduceSpeed();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == otherColliderTag)
        {
            Debug.Log("player exited");
            NormalSpeed();
        }
    }

    private void ReduceSpeed()
    {
        //Reduce player speed

        player = FindObjectOfType<Player>();

        if (player != null)
        {
           // player.speed /= speedReduction;
           // player.turnSpeed /= speedReduction;

            Debug.Log("speed reduced");
        }

    }

    private void NormalSpeed()
    {
        //Set speed back to normal

        player = FindObjectOfType<Player>();

        if (player != null)
        {
           // player.speed *= speedReduction;
           // player.turnSpeed *= speedReduction;

            Debug.Log("reduction removed");
        }
    }

    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        box.isTrigger = true;
           
    }
}
