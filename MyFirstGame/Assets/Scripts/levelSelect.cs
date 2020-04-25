using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour
{
    public int level;
    public GameObject button;
    int threshold;
    void Start()
    {
        try
        {
            playerData data = saveSystem.LoadPlayer();
            threshold = data.maxlevel;
        }
        catch
        {
            threshold = 1;
        }
        if (level > threshold)
		{
            button.SetActive(false);
		}
    }

    public void loadLevel ()
	{
        SceneManager.LoadScene(level);
    }
}
