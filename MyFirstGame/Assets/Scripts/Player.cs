using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 1;
    public int maxlevel;
    void Awake()
    {
        try
        {
            playerData data = saveSystem.LoadPlayer();
            maxlevel = data.maxlevel;
        }
        catch
        {
            maxlevel = 1;
        }
        level = SceneManager.GetActiveScene().buildIndex;
        if (level > maxlevel)
		{
            maxlevel = level;
		}
    }
    public void SavePlayer ()
	{
        saveSystem.savePlayer(this);
	}
    public void LoadPlayer ()
	{
        try
        {
            playerData data = saveSystem.LoadPlayer();
            level = data.level;
            FindObjectOfType<MainMenu>().loadGame(level);
        } catch
		{
            FindObjectOfType<MainMenu>().loadGame(1);
        }
    }
}
