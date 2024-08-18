using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    [SerializeField] Player player;
    void Update()
    {
        //When the player's health is 0 or less than 0, it switches to lose screen
        if (Player.health <= 0) 
        {
            SceneManager.LoadScene(1);
        }
    }
}
