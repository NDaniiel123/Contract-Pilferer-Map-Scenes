using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public void Retry()
    {
        SceneManager.LoadScene("Level Select");
        Time.timeScale = 1f;
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
