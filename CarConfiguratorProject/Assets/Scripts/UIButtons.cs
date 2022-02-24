using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
    public GameObject Wheels;
    public GameObject Colors;
    public GameObject ColorsScrollbar;

    public void WheelButton()
    {
        Wheels.SetActive(true);
        Colors.SetActive(false);
        ColorsScrollbar.SetActive(false);
    }
    public void ColorButton()
    {
       Colors.SetActive(true);
       ColorsScrollbar.SetActive(true);
       Wheels.SetActive(false);

    }
}
