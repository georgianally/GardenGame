﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biodome
{
    public string name { get; }
    public int money;
    public int ticketPrice;
    public int currentVisitors;
    public int totalVisitors;

    public Biodome()
    {
        name = "Garden";
        money = 100;
        ticketPrice = 1;
        currentVisitors = 10;
        totalVisitors = 0;
    }

}