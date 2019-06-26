using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biodome
{
    public string name { get; set; }
    public int money { get; set; }
    public int ticketPrice { get; }
    public int currentVisitors { get; set; }
    public int totalVisitors { get; set; }
    public float rating { get; set; }

    public Biodome()
    {
        name = "Garden";
        money = 100;
        rating = 0;
        ticketPrice = 1;
        currentVisitors = 0;
        totalVisitors = 0;
    }

    public void BuyItem(string item)
    {
        if(item == "plant")
        {
            money = money - 10;
            rating = rating + 0.1f;
        }
    }

    public void VisitorIn()
    {
        money = money + ticketPrice;
        currentVisitors++;
        totalVisitors++;
    }

    public void VisitorOut()
    {
        currentVisitors--;
    }



}
