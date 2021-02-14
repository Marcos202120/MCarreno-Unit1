﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Rate of movement forward and backwards
    private float speed = 15.0f;
    private float Tspeed = 15.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Debug.Log(Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //turning vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * Tspeed * horizontalInput);

    }
}
