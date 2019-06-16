using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonClick : MonoBehaviour
{
    public Text name;
    public Text money;
    Biodome biodome;

    void Start()
    {
        biodome = new Biodome();
    }

    public void clickTheButton()
    {
        biodome.money = biodome.money + biodome.ticketPrice;

        money.text = "Money: " + biodome.money.ToString();
        name.text = biodome.name;
    }

}
