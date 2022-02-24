using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorChanger : MonoBehaviour
{
    public Material[] colors;
    public ColorButton ColorButton;
    public GameObject Car;

    void Start()
    {
         for(int i = 0; i < colors.Length; i++)
        {   
            var ColorButtonClone = Instantiate(ColorButton, transform).GetComponent<ColorButton>();
            ColorButtonClone.ButtonInt = i;
            ColorButtonClone.ColorName.text = ($"COLOR {ColorButtonClone.ButtonInt}");  
            ColorButtonClone.Button.onClick.AddListener(()=>dothis(ColorButtonClone.ButtonInt));                    
        }
    }
    public void dothis(int number)
    {  
        Debug.Log(number);
        Car.GetComponent<MeshRenderer>().material = colors[number];

    }
}
