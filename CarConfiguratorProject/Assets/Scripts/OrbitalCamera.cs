using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{
    public Transform CameraPosition;
    public Transform Camera;
    public Camera cam;
    public float target = 40;

    public float Sensitivity;
    public float ScrollSensitivity;
    private float xRotation;
    private float yRotation;
    private float mouseX;
    private float mouseY;
    private float mouseWheel;

    void Update()
    {   
        if(Input.GetMouseButton(0))
        {
           mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
           mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

           yRotation += mouseX;
           xRotation += mouseY;
           if(xRotation >= 5)
           {
               xRotation = 5;
           }
           if(xRotation <= -15)
           {
               xRotation = -15;
           }

           transform.rotation = Quaternion.Euler(xRotation,yRotation,0);
        }
        if(Input.GetMouseButton(1))
        {
           mouseWheel = Input.GetAxis("Mouse ScrollWheel") * ScrollSensitivity * Time.deltaTime * 50;
           target = target -= mouseWheel;
           cam.fieldOfView = Mathf.MoveTowards(cam.fieldOfView, target, ScrollSensitivity * Time.deltaTime);   
        }

        if(cam.fieldOfView >= 100)
        {
            cam.fieldOfView = 100;
            target = 100;
        }
        if(cam.fieldOfView <= 20)
        {
            cam.fieldOfView = 20;
            target = 20;
        }

        
    }
}  
