using UnityEngine;

public class AiMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float horizontalForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //applies a forward force onto AI
        
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") ) {
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } 
        if ( Input.GetKey("a") ) {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( rb.position.y < 0f) {
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
