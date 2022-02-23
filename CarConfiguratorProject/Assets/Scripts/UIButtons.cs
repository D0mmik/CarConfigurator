using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtons : MonoBehaviour
{
    public GameObject Wheels;

    public void WheelButton()
    {
        Wheels.SetActive(true);
    }
    public void ColorButton()
    {
       Wheels.SetActive(false); 
    }
}
