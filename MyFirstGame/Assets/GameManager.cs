using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool endless = false;
    public static GameManager instance;
    public bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    public int coins = 0;
    public int coinsLim = 0;

    public void endGame () {
       if (gameHasEnded == false) {
        gameHasEnded = true;
        Invoke("Restart", restartDelay);
        
       }
   } 
   public void completeLevel () {
       completeLevelUI.SetActive(true);
    }

   public void NextLevel ()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } 

   public void Restart () {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
   public void endMusic ()
	{
        FindObjectOfType<AudioManager>().creditsMusic();
    }
   public void coinCol ()
	{
        coins += 1;
        Debug.Log(coins);
	}
   public void negCol()
    {
        coins -= 1;
        Debug.Log(coins);
    }
    public bool Pass ()
	{
        if (coins == coinsLim)
		{
            return true;
		}
        return false;
	}
}
