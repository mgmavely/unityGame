using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject controlsUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
		{
            if (isPaused)
			{
                Resume();
			} else
			{
                Pause();
			}
		}
    }

    public void Resume()
	{
        pauseMenuUI.SetActive(false);
        controlsUI.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void Pause()
	{
        controlsUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void menu ()
	{
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void quitGame ()
	{
        Application.Quit();
	}
    public void restart ()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
