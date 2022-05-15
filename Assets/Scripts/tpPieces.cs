using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpPieces : MonoBehaviour
{
    private playerMovement thePlayer;

    public GameObject theEffect, theTP, brokenTP;
    public bool catGo, waitingToGo;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToGo)
        {
            if (Vector3.Distance(thePlayer.followingKey.transform.position, transform.position) < 0.05f)
            {
                waitingToGo = false;
                catGo = true;

                thePlayer.followingKey.gameObject.SetActive(false);
                thePlayer.followingKey = null;

                theEffect.SetActive(true);
                Invoke(nameof(disableCats), 1f);

            }
        }

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (thePlayer.followingKey != null && thePlayer.followingKey.tag == "brokenPieces")
            {
                thePlayer.followingKey.followTarget = transform;
                waitingToGo = true;
            }
        }

    }

    private void disableCats()
    {
        brokenTP.SetActive(false);
        theEffect.SetActive(false); 
        theTP.SetActive(true);
    }
}