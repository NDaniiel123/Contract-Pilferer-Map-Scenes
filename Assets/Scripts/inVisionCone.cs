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



    }

}
