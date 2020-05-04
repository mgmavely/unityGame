using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveForce = 500f;
    void FixedUpdate()
    {
        if (FindObjectOfType<GameManager>().gameHasEnded == false)
        {
            rb.AddForce(0, 0, -moveForce * Time.deltaTime);
            if (gameObject.transform.position.z < -20)
            {
                Destroy(gameObject);
            }
        }
    }
}
