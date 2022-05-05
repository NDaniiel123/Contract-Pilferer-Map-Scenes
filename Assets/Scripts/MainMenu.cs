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
        SceneManager.LoadScene("stanLevel");
        Time.timeScale = 1f;
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("testLevel");
        Time.timeScale = 1f;
    }
}
