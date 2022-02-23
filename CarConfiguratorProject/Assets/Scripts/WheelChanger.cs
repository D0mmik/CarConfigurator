using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WheelChanger : MonoBehaviour
{
    public GameObject[] wheels;
    public WheelButton WheelButton;
    public GameObject currentclone;

    void Start()
    {
        //wheels = GameObject.FindGameObjectsWithTag("wheel");

        for(int i = 0; i < wheels.Length; i++)
        {   
            var WheelButtonClone = Instantiate(WheelButton, transform).GetComponent<WheelButton>();
            WheelButtonClone.ButtonInt = i;
            WheelButtonClone.WheelName.text = ($"WHEEL {WheelButtonClone.ButtonInt}");  
            WheelButtonClone.Button.onClick.AddListener(()=>dothis(WheelButtonClone.ButtonInt));        
        }
    }
    public void dothis(int number)
    {  Destroy(currentclone);
       Debug.Log(number);
       currentclone = Instantiate(wheels[number]);
    }


}
