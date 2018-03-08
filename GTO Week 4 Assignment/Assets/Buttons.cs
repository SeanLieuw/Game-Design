using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Buttons : MonoBehaviour {

    public Text myText;
    // Use this for initialization
    public void increaseNumber()
    {
        int number = Convert.ToInt32(myText.text);

        number = number +10;
        myText.text = number.ToString();
    }
    public void decreaseNumber()
    {
        int number = Convert.ToInt32(myText.text);
        number = number -10;

        myText.text = number.ToString();
    }
}
