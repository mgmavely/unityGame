using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementFinal : MonoBehaviour
{
    public Rigidbody rb;

    public float force = 500f;
    public float jumpForce = 7f;
    public int final = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        if ( Input.GetKey("d") ) {
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } 
        if ( Input.GetKey("a") ) {
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if ( Input.GetKey(KeyCode.Space) && isGrounded && transform.position.y >=1)
		{
            isGrounded = false;
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
		}
        if ( rb.position.y < 0f) {
            FindObjectOfType<GameManager>().endGame();
        }
    }
    public bool isGrounded = false;
}
