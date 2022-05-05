using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseDoor : MonoBehaviour
{
    [SerializeField] private ExitAnim exit;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            exit.Open();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            exit.Close();
        }
    }
  
}
