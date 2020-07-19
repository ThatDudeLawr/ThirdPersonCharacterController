using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public CharacterController controller;
    public Transform cam;

    public float movementSpeed = 6f;
    public float sprintSpeed = 12f;
    
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    [NonSerialized]
    public float horizontal;
    [NonSerialized]
    public float vertical;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance,groundMask);
        if(isGrounded && velocity.y<0)
        {
            velocity.y = -2f;
        }

        Vector3 inputDirection = new Vector3(horizontal, 0f, vertical).normalized;

        if(inputDirection.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            if (Input.GetButton("Sprint"))
            {
                controller.Move(moveDirection.normalized * sprintSpeed * Time.deltaTime);
            }
            else
            {
                controller.Move(moveDirection.normalized * movementSpeed * Time.deltaTime);
            }
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }
}
