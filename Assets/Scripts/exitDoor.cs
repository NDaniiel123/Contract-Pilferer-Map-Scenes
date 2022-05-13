using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitDoor : MonoBehaviour
{
    private playerMovement thePlayer;

    public GameObject anotherDoor;
    public bool doorOpen, waitingToOpen;
    public GameObject collectEffect;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToOpen)
        {
            if (Vector3.Distance(thePlayer.followingKey.transform.position, transform.position) < 0.05f)
            {
                waitingToOpen = false;
                doorOpen = true;

                thePlayer.followingKey.gameObject.SetActive(false);
                thePlayer.followingKey = null;

                collectEffect.SetActive(true);
                anotherDoor.SetActive(false);
            }
        }
        if (doorOpen && Vector3.Distance(thePlayer.transform.position, transform.position) < 0.5f && Input.GetAxis("Vertical") > 0.1f)
        {
            if (SceneManager.GetActiveScene().name == "level0")
            {
                SceneManager.LoadScene("level1");
            }
            else if (SceneManager.GetActiveScene().name == "level1")
            {
                SceneManager.LoadScene("level2");
            }
            else if (SceneManager.GetActiveScene().name == "level2")
            {
                SceneManager.LoadScene("level3");
            }
            else if (SceneManager.GetActiveScene().name == "level3")
            {
                SceneManager.LoadScene("level4");
            }
            print("haha");
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (thePlayer.followingKey != null)
            {
                thePlayer.followingKey.followTarget = transform;
                waitingToOpen = true;
            }
        }

        
    }
}