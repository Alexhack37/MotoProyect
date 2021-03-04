using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBike : MonoBehaviour
{
    public GameObject CarCam;
    public GameObject ThePlayer;
    public GameObject ExitTrigger;
    public GameObject TheCar;
    public GameObject ExitPlace;



    private void Update()
    {

        
        if (Input.GetKeyDown("e"))
        {
            ThePlayer.SetActive(true);
            ThePlayer.transform.position = ExitPlace.transform.position;
            CarCam.SetActive(false);
            //TheCar.GetComponent("CarUserControl").enabled = false;
            //TheCar.GetComponent("CarController").enabled = false;
            ExitTrigger.SetActive(false);

        }
    }

}
