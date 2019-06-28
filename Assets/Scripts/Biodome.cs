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
        rating = 0.0f;
    }

    public void BuyItem(int price)
    {
        money = money - price;
        rating = rating + price/10;
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
