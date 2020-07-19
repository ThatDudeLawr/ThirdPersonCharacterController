using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class BodyRotator : MonoBehaviour
{
    public float rotationSpeed = 1000f;
    public float deadZoneDegrees = 15f;

    private Transform cameraT;
    private Vector3 cameraDirection;
    private Vector3 playerDirection;
    private Quaternion targetRotation;

    private void Awake()
    {
        cameraT = Camera.main.transform;
    }

    private void Update()
    {
        cameraDirection = new Vector3(cameraT.forward.x, 0f, cameraT.forward.z);
        playerDirection = new Vector3(transform.forward.x, 0f, transform.forward.z);

        if (Vector3.Angle(cameraDirection, playerDirection) > deadZoneDegrees && CharacterController.anim.GetBool("IsMoving") == true)
        {
            targetRotation = Quaternion.LookRotation(cameraDirection, transform.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }


    }
}
*/