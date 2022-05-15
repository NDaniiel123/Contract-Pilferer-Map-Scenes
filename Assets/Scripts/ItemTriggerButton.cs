using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTriggerButton : MonoBehaviour
{
    private playerMovement thePlayer;

    private void Start()
    {       
        thePlayer = FindObjectOfType<playerMovement>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            thePlayer.collectPowerSound.Play();
            Destroy(gameObject);           
            //or gameObject.SetActive(false);
        }
    }


}