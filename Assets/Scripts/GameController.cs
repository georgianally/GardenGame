using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController SharedInstance;
    public Biodome biodome;
    public Text name;
    public Text money;
    public Text totalVisitors;
    public Text currentVisitors;
    public Text rating;
    public GameObject nameInputField;

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

    public void BuyPlant()
    {
        biodome.BuyItem("plant");
        rating.text = "Rating: " + biodome.rating.ToString();
        money.text = "Money: " + biodome.money.ToString();
    }

    public void VisitorEnter()
    {
        biodome.VisitorIn();

        totalVisitors.text = "Total Visitors: " + biodome.totalVisitors.ToString();
        currentVisitors.text = "Current Visitors: " + biodome.currentVisitors.ToString();
        money.text = "Money: " + biodome.money.ToString();
    }

    public void VisitorExit()
    {
        biodome.VisitorOut();
        currentVisitors.text = "Current Visitors: " + biodome.currentVisitors.ToString();
    }
}