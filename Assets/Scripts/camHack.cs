using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camHack : MonoBehaviour
{
    private playerMovement thePlayer;

    public GameObject camCone;
    public bool waitingToHack;



    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToHack)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                waitingToHack = false;

                camCone.SetActive(false);
            }
        }

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (thePlayer.hasLP == 1)
            {
                waitingToHack = true;
            }
        }


    }
}