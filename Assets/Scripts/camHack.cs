using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camHack : MonoBehaviour
{
    private playerMovement thePlayer;
    private hackCoolDown hackTimer;

    public GameObject camCone;
    public bool waitingToHack;



    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<playerMovement>();
        hackTimer = FindObjectOfType<hackCoolDown>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToHack && !hackTimer.timerIsRunning)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                waitingToHack = false;

                hackTimer.timerIsRunning = true;
                camCone.SetActive(false);
            }
        }

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (thePlayer.hasHack == 1)
            {
                waitingToHack = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (thePlayer.hasHack == 1)
            {
                waitingToHack = false;
            }
        }
    }
}