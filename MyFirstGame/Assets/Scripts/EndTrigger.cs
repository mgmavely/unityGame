using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Text attempts;
    void OnTriggerEnter () {
        if (gameManager.Pass())
        {
            gameManager.completeLevel();
        } else
		{
            FindObjectOfType<AudioManager>().Play("Crash");
            gameManager.Restart();
		}
    }
}
