using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutSensitivity = 2f;
    [SerializeField] float zoomedInSensitivity = .5f;

    bool zoomedInToogle = false;

    private void OnDisable()
    {
        ZoomOut();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToogle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }

      
    }  
        public void ZoomIn()
        {
            zoomedInToogle = true;
            cam.fieldOfView = zoomedInFOV;
            fpsController.mouseLook.XSensitivity = zoomedInSensitivity;
            fpsController.mouseLook.YSensitivity = zoomedInSensitivity;
        }

        public void ZoomOut()
        {
            zoomedInToogle = false;
            cam.fieldOfView = zoomedOutFOV;
            fpsController.mouseLook.XSensitivity = zoomedOutSensitivity;
            fpsController.mouseLook.YSensitivity = zoomedOutSensitivity;
        }
}
