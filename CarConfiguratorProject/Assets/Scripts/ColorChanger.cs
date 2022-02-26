using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorChanger : MonoBehaviour
{
    public Material[] colors;
    public Buttons Buttons;
    public GameObject Car;
    public int currentColor;

    void Start()
    {
         for(int i = 0; i < colors.Length; i++)
        {   
            var ColorButtonClone = Instantiate(Buttons, transform).GetComponent<Buttons>();
            ColorButtonClone.ButtonInt = i;
            ColorButtonClone.Name.text = ($"COLOR {ColorButtonClone.ButtonInt}");  
            ColorButtonClone.Button.onClick.AddListener(()=>dothis(ColorButtonClone.ButtonInt));                    
        }
    }
    public void dothis(int number)
    {  
        currentColor = number;
        Car.GetComponent<MeshRenderer>().material = colors[number];

    }
}
