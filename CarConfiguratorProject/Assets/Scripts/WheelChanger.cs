using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WheelChanger : MonoBehaviour
{
    public GameObject[] wheels;
    public Buttons Buttons;
    public GameObject currentclone;
    public int currentWheel;


    void Start()
    {

        for(int i = 0; i < wheels.Length; i++)
        {   
            var WheelButtonClone = Instantiate(Buttons, transform).GetComponent<Buttons>();
            WheelButtonClone.ButtonInt = i;
            WheelButtonClone.Name.text = ($"WHEEL {WheelButtonClone.ButtonInt}");  
            WheelButtonClone.Button.onClick.AddListener(()=>dothis(WheelButtonClone.ButtonInt));        
        }
    }
    public void dothis(int number)
    {  Destroy(currentclone);
       currentWheel = number;
       currentclone = Instantiate(wheels[number]);
    }


}
