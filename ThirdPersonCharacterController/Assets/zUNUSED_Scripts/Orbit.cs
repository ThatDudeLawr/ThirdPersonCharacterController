﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class Orbit : MonoBehaviour
{
    private const float Y_ANGLE_MIN = -20.0f;
    private const float Y_ANGLE_MAX = 50.0f;


    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    [SerializeField]
    private float distanceToPlayer = 4.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    [SerializeField]  
    private float sensitivityX = 4.0f;
    [SerializeField]
    private float sensitivityY = 1.0f;

    private void Start()
    {

        camTransform = transform;
        cam = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += -Input.GetAxis("Mouse Y");
        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distanceToPlayer);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }

}
*/