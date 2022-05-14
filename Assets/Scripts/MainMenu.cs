using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public void Level1()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 1f;
    }
    public void Level2()
    {
        SceneManager.LoadScene("level2");
        Time.timeScale = 1f;
    }
    public void Level3()
    {
        SceneManager.LoadScene("level3");
        Time.timeScale = 1f;
    }
    public void Level4()
    {
        SceneManager.LoadScene("level4");
        Time.timeScale = 1f;
    }

    public void Tutorial1()
    {
        SceneManager.LoadScene("tut1");
        Time.timeScale = 1f;
    }
    public void Tutorial2()
    {
        SceneManager.LoadScene("tut2");
        Time.timeScale = 1f;
    }
    public void Tutorial3()
    {
        SceneManager.LoadScene("tut3");
        Time.timeScale = 1f;
    }
    public void Tutorial4()
    {
        SceneManager.LoadScene("tut4");
        Time.timeScale = 1f;
    }
    public void Tutorial5()
    {
        SceneManager.LoadScene("tut5");
        Time.timeScale = 1f;
    }
    public void Tutorial6()
    {
        SceneManager.LoadScene("tut6");
        Time.timeScale = 1f;
    }
    
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Continue()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void QuitMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 1f;
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
        Time.timeScale = 1f;
    }
    public void TutorialSelect()
    {
        SceneManager.LoadScene("Tutorial Select");
        Time.timeScale = 1f;
    }
}
