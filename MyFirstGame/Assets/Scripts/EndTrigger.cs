using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter () {
        if (gameManager.Pass() && gameManager.endless == false)
        {
            Deubg.Log("one");
            gameManager.completeLevel();
        } else if (FindObjectOfType<GameManager>().gameHasEnded == false &&
            FindObjectOfType<GameManager>().endless == true)
        {
            Deubg.Log("two");
            FindObjectOfType<levelGenerator>().Spawn();
        } else
		{
            Deubg.Log("three");
            FindObjectOfType<AudioManager>().Play("Crash");
            gameManager.Restart();
		}
    }
}
