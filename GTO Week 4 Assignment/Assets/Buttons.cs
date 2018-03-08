using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Buttons : MonoBehaviour {

    public Text HealthPoints;
    public Text ManaPoints;
    public void increaseHealth()
    {
        int number = Convert.ToInt32(HealthPoints.text);
        if (number >= 100)
        {
            number = 100;
        }
        else
        {
            number = number + 10;
        }
        HealthPoints.text = number.ToString();
    }
    public void decreaseHealth()
    {
        int number = Convert.ToInt32(HealthPoints.text);
        if (number <= 0)
        {
            number = 0;
        }
        else
        {
            number = number - 10;
        }
        HealthPoints.text = number.ToString();
    }
    public void increaseMana()
    {
        int number = Convert.ToInt32(ManaPoints.text);
        if (number >= 100)
        {
            number = 100;
        }
        else
        {
            number = number + 10;
        }
        ManaPoints.text = number.ToString();
    }
    public void decreaseMana()
    {
        int number = Convert.ToInt32(ManaPoints.text);
        if (number <= 0)
        {
            number = 0;
        }
        else
        {
            number = number - 10;
        }
        ManaPoints.text = number.ToString();
    }
}
