using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private playerMovement myPlayer;
    private GameObject teleporter1;

    private void Start()
    {
        myPlayer = FindObjectOfType<playerMovement>();
    }
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.F) && myPlayer.hasTP == 1) 
        {
            if (teleporter1 != null) 
            {
                transform.position = teleporter1.GetComponent<Teleporters>().GetDestination().position;               
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            teleporter1 = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter")) 
        {
            if (collision.gameObject == teleporter1) 
            {
                teleporter1 = null;
            }
            
        }
    }
}
