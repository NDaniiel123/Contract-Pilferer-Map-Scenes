using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disguisePower : MonoBehaviour
{
    public float timeRemaining, cooldownTime;
    public bool timerIsRunning = false, timerIsCoolDown = false;
    public Text cooldownText, timerText;
    private Animator animator;
    public RuntimeAnimatorController disguiseAnim, normalAnim;
    private bool transformed = false;
    private BoxCollider2D b;
    public GameObject[] guardNo;
    private playerMovement thePlayer;

    private void Start()
    {
        // Starts the timer automatically
        b = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        thePlayer = FindObjectOfType<playerMovement>();
    }
    void Update()
    {
        if (thePlayer.hasDis == 1)
        {
            if (Input.GetKeyDown(KeyCode.G) && !timerIsCoolDown)
            {
                foreach (GameObject guards in guardNo)
                {
                    guards.SetActive(false);
                }
                timerText.gameObject.SetActive(true);
                timerIsRunning = true;
                timeRemaining = 10;
                if (!transformed)
                {
                    animator.runtimeAnimatorController = disguiseAnim as RuntimeAnimatorController;
                    transformed = true;
                    transform.position += new Vector3(0, 0.69f, 0);
                    b.offset = new Vector2(0f, -0.25f);
                }
            }

            if (timerIsRunning)
            {
                if (timeRemaining > 0)
                {
                    Debug.Log("Runiing");
                    timeRemaining -= Time.deltaTime;
                    DisplayTime(timeRemaining, timerText);
                }
                else
                {
                    Debug.Log("Time has run out!");
                    timeRemaining = 0;
                    timerIsRunning = false;
                    cooldownTime = 10;
                    timerIsCoolDown = true;
                    cooldownText.gameObject.SetActive(true);
                    timerText.gameObject.SetActive(false);

                }
            }

            if (transformed && !timerIsRunning)
            {
                foreach (GameObject guards in guardNo)
                {
                    guards.SetActive(true);
                }
                animator.runtimeAnimatorController = normalAnim as RuntimeAnimatorController;
                transformed = false;
                transform.position -= new Vector3(0, 0.69f, 0);
                b.offset = new Vector2(0f, 0.4643871f);
            }

            if (timerIsCoolDown)
            {
                if (cooldownTime > 0)
                {
                    cooldownTime -= Time.deltaTime;
                    DisplayTime(cooldownTime, cooldownText);
                }
                else
                {
                    Debug.Log("Time has run out!");
                    cooldownTime = 0;
                    timerIsCoolDown = false;
                    cooldownText.gameObject.SetActive(false);
                }
            }
        }
        
    }
    void DisplayTime(float timeToDisplay, Text myText)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        myText.text = string.Format("{0}:{1:00}", minutes, seconds);
    }
}