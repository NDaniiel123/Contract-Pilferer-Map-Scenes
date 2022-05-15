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
        SceneManager.LoadScene("Level1");
    }
    public void Retry2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Retry3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Retry4()
    {
        SceneManager.LoadScene("Level4");
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
