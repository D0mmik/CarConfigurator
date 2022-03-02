using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{
    public Transform CameraPosition;
    public Transform Camera;
    public Camera cam;
    public float target = 40;
    public UIButtons uIButtons;

    public float Sensitivity;
    public float ScrollSensitivity;
    private float xRotation;
    private float xRot;
    private float yRotation;
    private float mouseX;
    private float mouseY;
    private float mouseWheel;
    private float speed = 150;
    public bool dragging = false;
    private Rigidbody rb;

    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    void Update()
    {   
        if(uIButtons.canOrbit == true)
        {
           if(Input.GetMouseButtonDown(0))
           {
              dragging = true;
           } 
           if(Input.GetMouseButtonUp(0))
           {
              dragging = false;
           }
         
           if(dragging)
           {          
              mouseX = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
              rb.AddTorque(Vector3.up * mouseX);

              mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

              xRotation += mouseY;
              if(xRotation >= 5)
              {
                xRotation = 5;
              }
              if(xRotation <= -15)
              {
                xRotation = -15;
              }
           }
           xRot = Mathf.MoveTowards(xRot, xRotation, 0.2f);
           transform.rotation = Quaternion.Euler(xRot,transform.eulerAngles.y,0);
      
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
}  
