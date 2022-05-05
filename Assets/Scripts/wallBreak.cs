using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallBreak : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.F) )
        {
            Destroy(gameObject);
            //or gameObject.SetActive(false);
        }
    }


}