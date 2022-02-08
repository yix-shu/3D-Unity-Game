﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //constant forward movement
        if (Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //ForceMode will allow us to specific which way to add a force
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
