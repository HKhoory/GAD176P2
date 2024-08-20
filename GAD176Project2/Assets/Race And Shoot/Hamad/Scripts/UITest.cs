using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class UITest : MonoBehaviour
{

    /// <summary>
    /// Responsible for manaing the UI in relation to the player's status
    /// Displays both health and bullet in use
    /// </summary>


    [SerializeField] private TextMeshProUGUI pHealth; //for displaying the player's health
    [SerializeField] private TextMeshProUGUI weaponText; //for displayuing the player's bullet type
    [SerializeField] private float timer; //timer to prevent the player from swapping the weapons fast

    float timerStore; //for storing the initial value of timer
    bool weaponFlip; //the state of the weapon, either lazer or asetroid

    // Start is called before the first frame update
    void Start()
    {
        timerStore = timer; //sets timerStore to timer
        weaponFlip = false; //sets weaponFlip to false
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime; //decreases timer by the time that passes
        pHealth.text = "Health: " + Player.health.ToString(); //displays the player health in the UI

    }

    public void ChangeWeapon() //runs when the button is pressed by the player
    {

        if (timer <= 0 && weaponFlip)
        {
            weaponText.text = "Lazer";
            timer = timerStore;
            weaponFlip = false;
        }
        else if (timer <= 0 && !weaponFlip)
        {
            weaponText.text = "Asetroid";
            timer = timerStore;
            weaponFlip = true;
        }
        //call unity delegate
        //have a timer

    }

}
