using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biodome
{
    public string name { get; }
    public int money { get; set; }
    public int ticketPrice { get; }
    public int currentVisitors { get; set; }
    public int totalVisitors { get; set; }

    public Biodome()
    {
        name = "Garden";
        money = 100;
        ticketPrice = 1;
        currentVisitors = 0;
        totalVisitors = 0;
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
