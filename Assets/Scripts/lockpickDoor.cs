using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lockpickDoor : MonoBehaviour
{
    private playerMovement thePlayer;

    public GameObject anotherDoor;
    public bool waitingToOpen;
    


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
            if (Input.GetKeyDown(KeyCode.F))
            {
                waitingToOpen = false;
                
                anotherDoor.SetActive(false);
            }
        }
        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (thePlayer.hasLP == 1)
            {
                waitingToOpen = true;
            }
        }


    }
}