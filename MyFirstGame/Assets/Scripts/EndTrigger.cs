using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter (Collider c)
    {
        
        if (c.tag == "Player" && FindObjectOfType<GameManager>().gameHasEnded == false)
        {
            Debug.Log("trigger");

            if (FindObjectOfType<GameManager>().Pass() &&
                FindObjectOfType<GameManager>().endless == false)
            {
                FindObjectOfType<GameManager>().completeLevel();
            }
            else if (FindObjectOfType<GameManager>().gameHasEnded == false &&
                  FindObjectOfType<GameManager>().endless == true)
            {
                FindObjectOfType<levelGenerator>().Spawn();
            }
            else
            {
                FindObjectOfType<AudioManager>().Play("Crash");
                FindObjectOfType<GameManager>().Restart();
            }
            Destroy(gameObject);
        }
    }
}