using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoDrive : MonoBehaviour
{
    private Rigidbody player;
    public float speed;
    public float turnspeed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        EnterBike enter = gameObject.GetComponent<EnterBike>();
        if (enter.IsOnBike.Equals(true))
        {
            Console.WriteLine("ESTOY AL CONTROL DEL VEHICULO");
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddRelativeForce(Vector3.forward * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddRelativeForce(Vector3.forward * speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddTorque(Vector3.up * turnspeed);
                Debug.Log("estoy girando a la derecha");
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddTorque(-Vector3.up * turnspeed);
                Debug.Log("estoy girando a la derecha");
            }
        }
        

    }
}
