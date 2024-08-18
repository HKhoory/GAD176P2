using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITest : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI pHealth;
    [SerializeField] private Button changeWeaponButton;

    // Start is called before the first frame update
    void Start()
    {
        changeWeaponButton = GetComponent<Button>();
        pHealth.text = "Health: " + Player.health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //if (changeWeaponButton.)
    }

    public void ChangeWeapon()
    {

        //call unity delegate
        //have a timer

    }

}
