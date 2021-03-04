

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBike : MonoBehaviour
{

    public GameObject CarCam;
    public GameObject ThePlayer;
    public GameObject ExitTrigger;
    public GameObject TheCar;
    int TriggerCheck;
    public bool IsOnBike;

    public void OnTriggerEnter()
    {
        TriggerCheck = 1;
        IsOnBike = false;
    }
    public void OntTriggerExit()
    {
        TriggerCheck = 0;
    }

    private void Update()
    {
        
        if (TriggerCheck == 1)
        {
            if (Input.GetKeyDown("e"))
            {
                IsOnBike = true;
                Debug.Log("estoy subido");
                
                CarCam.SetActive(true);
                ThePlayer.SetActive(false);
                //TheCar.GetComponent("CarController").enabled = true;
                //TheCar.GetComponent("CarUserControl").enabled = true;
                ExitTrigger.SetActive(true);
            }
        }
    }

}
    
