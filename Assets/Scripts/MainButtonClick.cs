using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonClick : MonoBehaviour
{
    public Text name;
    Biodome biodome;

    void Start()
    {
        biodome = new Biodome();
    }

    public void clickTheButton()
    {
        name.text = biodome.name;
    }

}
