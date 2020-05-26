using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;
    void OnCollisionEnter (Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle" ||
            collisionInfo.collider.tag == "clickWall")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().endGame();
            FindObjectOfType<AudioManager>().Play("Crash");
        } else if (collisionInfo.collider.tag == "skipWall")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().nextGame();
            FindObjectOfType<AudioManager>().Play("Crash");
        } else if (collisionInfo.collider.tag == "Ground")
        {
            movement.isGrounded = true;
        }
        else if (collisionInfo.collider.tag == "Player")
		{
            movement.enabled = false;
		}
    }
}
