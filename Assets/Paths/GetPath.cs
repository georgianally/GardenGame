﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPath : MonoBehaviour
{
    public GameObject[] allPaths;


    void Start()
    {
        int num = Random.Range(0, allPaths.Length);
        transform.position = allPaths[num].transform.position;
        MoveOnPathScript yourPath = GetComponent<MoveOnPathScript>();
        yourPath.pathName = allPaths[num].name;
    }

}
