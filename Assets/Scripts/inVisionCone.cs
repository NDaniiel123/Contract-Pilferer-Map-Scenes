using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class inVisionCone : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "level1")
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        if (collision.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "level2")
            {
                SceneManager.LoadScene("GameOver2");
            }
        }
        if (collision.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "level3")
            {
                SceneManager.LoadScene("GameOver3");
            }
        }
        if (collision.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "level4")
            {
                SceneManager.LoadScene("GameOver4");
            }
        }
        if (collision.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "tut1")
            {
                SceneManager.LoadScene("GameOverT1");
            }
            if (collision.tag == "Player")
            {
                if (SceneManager.GetActiveScene().name == "tut2")
                {
                    SceneManager.LoadScene("GameOverT2");
                }
                if (collision.tag == "Player")
                {
                    if (SceneManager.GetActiveScene().name == "tut3")
                    {
                        SceneManager.LoadScene("GameOverT3");
                    }
                    if (collision.tag == "Player")
                    {
                        if (SceneManager.GetActiveScene().name == "tut4")
                        {
                            SceneManager.LoadScene("GameOverT4");
                        }
                        if (collision.tag == "Player")
                        {
                            if (SceneManager.GetActiveScene().name == "tut5")
                            {
                                SceneManager.LoadScene("GameOverT5");
                            }
                            if (collision.tag == "Player")
                            {
                                if (SceneManager.GetActiveScene().name == "tut6")
                                {
                                    SceneManager.LoadScene("GameOverT6");
                                }





                            }

                        }
                    }
                }
            }
        }
    }
}
