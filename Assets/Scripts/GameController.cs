using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController SharedInstance;
    Biodome biodome;
    public Text money;

    void Awake()
    {
        SharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        biodome = new Biodome();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementMoney()
    {
        biodome.money = biodome.money + biodome.ticketPrice;

        money.text = "Money: " + biodome.money.ToString();
    }
}