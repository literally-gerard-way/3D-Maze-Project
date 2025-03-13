using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //We put information at the start of a class
    public float speed = 4.5f;
    public float jumpForce = 5;
    public string hero = "Redd";

    //xyz coordinates
    public Vector3 direction;

    public Rigidbody playerRb;
    // Start is called once before the first frame update
    void Start()
    {
        Debug.Log("My name is " + hero);
    }

    // physics loop
    void FixedUpdate()
    {
        Vector3 velocity = direction * speed;
        //the dot is there to access a functionality of "transform"
        //transform.Translate(direction*Time.deltaTime*speed);  not good for rigid body physics
        velocity.y = playerRb.linearVelocity.y;

        playerRb.linearVelocity = velocity;
    }

    private void OnMove(InputValue value)
    {
        //Asks the input system what keys are being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x,0,inputValue.y);
    }

    private void OnJump(InputValue value)
    {
        //Physics.Raycast casts a line that can hit other colliders, starting from players position, going down for 0.6 units - if it finds another collider, returns true
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);
        if (isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
