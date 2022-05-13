using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitAnim : MonoBehaviour
{
    private Animator animator;
    private void Awake() 
    {
        animator = GetComponent<Animator>();
    }

    public void Open() 
    {
        animator.SetBool("open", true);
    }
    public void Close()
    {
        animator.SetBool("open", false);
    }

}
