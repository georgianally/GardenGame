﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController SharedInstance;
    Biodome biodome;
    public Text money;
    public Text totalVisitors;
    public Text currentVisitors;

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