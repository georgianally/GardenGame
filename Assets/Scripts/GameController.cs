using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController SharedInstance;
    Biodome biodome;
    public Text name;
    public Text money;
    public Text totalVisitors;
    public Text currentVisitors;
    public GameObject nameInputField;
    public GameObject flowerImage;
    public GameObject flowerButton;
    public GameObject shrubImage;
    public GameObject shrubButton;

    void Awake()
    {
        SharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        biodome = new Biodome();
    }

    public void GetInput(string enterName)
    {
        biodome.name = enterName;
        name.text = biodome.name;
        nameInputField.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyItem(string item)
    {
        switch (item)
        {
            case "Flower":
                biodome.BuyItem(10);
                flowerImage.SetActive(true);
                flowerButton.SetActive(false);
                break;
            case "Shrub":
                biodome.BuyItem(20);
                shrubImage.SetActive(true);
                shrubButton.SetActive(false);
                break;
            default:
                break;
        }
        DisplayMoney();
    }

    public void VisitorEnter()
    {
        biodome.VisitorIn();

        totalVisitors.text = "Total Visitors: " + biodome.totalVisitors.ToString();
        currentVisitors.text = "Current Visitors: " + biodome.currentVisitors.ToString();
        DisplayMoney();
    }

    public void VisitorExit()
    {
        biodome.VisitorOut();
        currentVisitors.text = "Current Visitors: " + biodome.currentVisitors.ToString();
    }

    private void DisplayMoney()
    {
        money.text = "Money: " + biodome.money.ToString();
    }
}