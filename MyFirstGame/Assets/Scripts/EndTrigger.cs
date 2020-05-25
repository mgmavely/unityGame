using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter () {
        if (gameManager.Pass() && gameManager.endless == false)
        {
            Debug.Log("one");
            gameManager.completeLevel();
        } else if (FindObjectOfType<GameManager>().gameHasEnded == false &&
            FindObjectOfType<GameManager>().endless == true)
        {
            Debug.Log("two");
            FindObjectOfType<levelGenerator>().Spawn();
        } else
		{
            Debug.Log("three");
            FindObjectOfType<AudioManager>().Play("Crash");
            gameManager.Restart();
		}
    }
}
