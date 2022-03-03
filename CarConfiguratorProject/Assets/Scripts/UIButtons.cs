using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using DG.Tweening;

public class UIButtons : MonoBehaviour
{
    public GameObject[] windows;
    public AudioSource motorSound;
    private bool motorPlaying = false;
    public GameObject Cam;
    public Camera MainCamera;
    public bool canOrbit;
    
    void Start()
    {
        canOrbit = false;
        Cam.transform.DOMove(new Vector3(-2.36f,1.35f,4.27f),2);
        Cam.transform.DORotate(new Vector3(0f,145.108f,0f),2);
    }

    void Target()
    {
        MainCamera.fieldOfView = 40; 
    }
    
    public void ToggleWindow(string nameOfWindow)
    {
        foreach( var item in windows)
        {
            item.SetActive(false);
        }
        windows.Single((x)=> x.name == nameOfWindow).SetActive(true);
    }

    public void WheelButton()
    {   
        ToggleWindow("Wheels");
        Target();
        canOrbit = false;
        Cam.transform.DOMove(new Vector3(-2.23f,0.95f,1.59f),2);
        Cam.transform.DORotate(new Vector3(0,90,0),2);
    }

    public void ColorButton()
    {
        ToggleWindow("Colors");
        Target();      
        canOrbit = false;
        Cam.transform.DOMove(new Vector3(-3.54f,1.5f,3.02f),2);
        Cam.transform.DORotate(new Vector3(0f,127.239f,0f),2);
    }

    public void SpoilerButton()
    {
        ToggleWindow("Spoilers");
        Target();
        canOrbit = false;
        Cam.transform.DOMove(new Vector3(0,1.48f,-4.78f), 2);
        Cam.transform.DORotate(new Vector3(3.765f,0,0),2);

    }
    public void CameraButton()
    {
        canOrbit = true;
        foreach( var item in windows)
        {
            item.SetActive(false);
        }
        Cam.transform.DOMove(new Vector3(0f,1.17f,6f),2);
        Cam.transform.DORotate(new Vector3(0f,180f,0f),2);

    }

    public void CloseButton()
    {
        foreach( var item in windows)
        {
            item.SetActive(false);
        }
        Cam.transform.DOMove(new Vector3(-2.36f,1.35f,4.27f),2);
        Cam.transform.DORotate(new Vector3(0f,145.108f,0f),2);
        canOrbit = false;
    }

    public void SaveConfigWindow()
    {
        ToggleWindow("SaveConfig");
    }

    public void LoadConfigWindow()
    {
        ToggleWindow("LoadConfig");
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
        canOrbit = false;

    }
}


