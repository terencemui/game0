using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float moveSpeed = 40;

    float horizontalInput = 0;
    bool jump = false;
    bool crouch = false;


    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal") * moveSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalInput * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
