using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public void StartGame()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 1f;
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("level0");
        Time.timeScale = 1f;
    }
}
