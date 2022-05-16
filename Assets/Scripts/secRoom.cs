using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secRoom : MonoBehaviour
{
    private playerMovement thePlayer;

    public GameObject[] camConnect;
    public GameObject parentObj;
    public bool waitingToHack;
    public Sprite hackedSprite;
    private SpriteRenderer mySprite;


    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<playerMovement>();
        mySprite = parentObj.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToHack)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                waitingToHack = false;
                mySprite.sprite = hackedSprite;

                thePlayer.hackSound.Play();

                foreach (GameObject cams in camConnect)
                {
                    cams.SetActive(false);
                }

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
}