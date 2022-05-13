using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private GameObject teleporter1;

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.F)) 
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
