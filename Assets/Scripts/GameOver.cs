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

    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
        Time.timeScale = 1f;

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
    public void RetryT1()
    {
        SceneManager.LoadScene("tut1");
    }
    public void RetryT2()
    {
        SceneManager.LoadScene("tut2");
    }
    public void RetryT3()
    {
        SceneManager.LoadScene("tut3");
    }
    public void RetryT4()
    {
        SceneManager.LoadScene("tut4");
    }
    public void RetryT5()
    {
        SceneManager.LoadScene("tut5");
    }
    public void RetryT6()
    {
        SceneManager.LoadScene("tut6");
    }



    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}


