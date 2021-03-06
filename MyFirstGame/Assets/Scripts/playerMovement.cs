﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float horizontalForce = 500f;
    public float jumpForce = 7f;
    public bool isGrounded = false;
    public int final = 0;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (final == 0)
        {

            //applies a forward force onto player

            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey("d"))
            {
                rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.Space) && isGrounded && transform.position.y >= 1)
            {
                isGrounded = false;
                rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            }
            if (rb.position.y < 0f)
            {
                FindObjectOfType<GameManager>().endGame();
            }
        } else
		{
            if (Input.GetKey("d"))
            {
                rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("w"))
            {
                rb.AddForce(0, 0, horizontalForce * Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey("s"))
            {
                rb.AddForce(0, 0, -horizontalForce * Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.Space) && isGrounded && transform.position.y >= 1)
            {
                isGrounded = false;
                rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            }
            if (rb.position.y < 0f)
            {
                FindObjectOfType<GameManager>().endGame();
            }
        }
    }
}
