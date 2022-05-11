using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Transform keyFollowPoint;
    public Key followingKey;
    public int hasLP = 0;

    Vector2 movement;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        lockPick();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement.x < 0)
        {
            animator.SetBool("IsMoving", true);
            animator.SetInteger("Direction", 3);
        }
        else if (movement.x > 0)
        {
            animator.SetBool("IsMoving", true);
            animator.SetInteger("Direction", 2);
        }

        else if (movement.y > 0)
        {
            animator.SetBool("IsMoving", true);
            animator.SetInteger("Direction", 1);
        }
        else if (movement.y < 0)
        {
            animator.SetBool("IsMoving", true);
            animator.SetInteger("Direction", 0);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            Debug.Log("Walls");
        }

        if (collision.gameObject.tag == "LockPick" && hasLP == 0)
        {
            hasLP = 1;
        }
    }

    private void lockPick()
    {
        if (SceneManager.GetActiveScene().name != "level1")
        {
            hasLP = 1;
        }
    }
}