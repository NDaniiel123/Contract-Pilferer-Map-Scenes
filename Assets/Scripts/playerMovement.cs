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
    public int hasLP = 0, hasTP = 0, hasHack = 0, hasDis = 0;
    public GameObject[] itemInvent;
    

    Vector2 movement;
    private Animator animator;
    

    private void Start()
    {
        animator = GetComponent<Animator>();
        itemsInvent();
        
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
        
        if (collision.gameObject.tag == "LockPick" && hasLP == 0)
        {
            itemInvent[0].SetActive(true);
            hasLP = 1;
        }
        if (collision.gameObject.tag == "TeleportPower" && hasTP == 0)
        {
            itemInvent[2].SetActive(true);
            hasTP = 1;
        }
        if (collision.gameObject.tag == "hackPower" && hasHack == 0)
        {
            itemInvent[1].SetActive(true);
            hasHack = 1;
        }
        if (collision.gameObject.tag == "disguisePower" && hasDis == 0)
        {
            itemInvent[3].SetActive(true);
            hasDis = 1;
        }
    }

    private void itemsInvent()
    {
        if (SceneManager.GetActiveScene().name != "level1" && SceneManager.GetActiveScene().name != "level0")
        {
            hasLP = 1;
        }
        if (SceneManager.GetActiveScene().name == "level4")
        {
            hasTP = 1;
        }
        if (SceneManager.GetActiveScene().name == "level3" || SceneManager.GetActiveScene().name == "level4")
        {
            hasHack = 1;
        }     

    }
}