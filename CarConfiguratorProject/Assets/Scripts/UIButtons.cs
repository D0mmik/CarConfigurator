using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
    public GameObject Wheels;
    public GameObject Colors;
    public GameObject Spoilers;
    public GameObject LoadWindow;
    public GameObject SaveWindow;
    public AudioSource motorSound;
    private bool motorPlaying = false;


    public void WheelButton()
    {
        Wheels.SetActive(true);
        Colors.SetActive(false);
        Spoilers.SetActive(false);
        LoadWindow.SetActive(false);
        SaveWindow.SetActive(false);
    }
    public void ColorButton()
    {
       Colors.SetActive(true);
       Wheels.SetActive(false);
       Spoilers.SetActive(false);
       LoadWindow.SetActive(false);
       SaveWindow.SetActive(false);
    }
    public void SpoilerButton()
    {
       Spoilers.SetActive(true); 
       Wheels.SetActive(false);
       Colors.SetActive(false);
       LoadWindow.SetActive(false);
       SaveWindow.SetActive(false);
    }
    public void CloseButton()
    {
        Wheels.SetActive(false);
        Colors.SetActive(false);
        Spoilers.SetActive(false);
        LoadWindow.SetActive(false);
        SaveWindow.SetActive(false);
    }
    public void SaveConfigWindow()
    {
        SaveWindow.SetActive(true);
        LoadWindow.SetActive(false);
        Wheels.SetActive(false);
        Colors.SetActive(false);
        Spoilers.SetActive(false);
    }
    public void LoadConfigWindow()
    {
        LoadWindow.SetActive(true);
        SaveWindow.SetActive(false);
        Wheels.SetActive(false);
        Colors.SetActive(false);
        Spoilers.SetActive(false);
    }
    public void MotorSound()
    {
        if(motorPlaying == false)
        {
            motorSound.Play();
            motorPlaying = true;
        }
        else
        {
            motorSound.Stop();
            motorPlaying = false;
        }

    }
}


