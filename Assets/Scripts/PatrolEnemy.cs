using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    public float speed;
    public Transform[] patrolPoints;
    public float waitTime;
    int currentPointIndex;

    bool once;
    private Animator animator;
    public GameObject visionCone;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
       if(transform.position != patrolPoints[currentPointIndex].position)
        {           
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, speed * Time.deltaTime);
            if (patrolPoints[currentPointIndex].position.x - 4f > transform.position.x)
            {
                animator.SetInteger("guardDirections", 1);
                
                StartCoroutine(rotateDelay(0, 0.1f));

            }
            else if (patrolPoints[currentPointIndex].position.x + 4f < transform.position.x)
            {
                animator.SetInteger("guardDirections", 0);
                
                StartCoroutine(rotateDelay(1, 0.1f));

            }
            else if (patrolPoints[currentPointIndex].position.y - 4f > transform.position.y)
            {
                animator.SetInteger("guardDirections", 2);

                StartCoroutine(rotateDelay(2, 0.1f));

            }
            else if (patrolPoints[currentPointIndex].position.y + 4f < transform.position.y)
            {
                animator.SetInteger("guardDirections", 3);
                StartCoroutine(rotateDelay(3, 0.1f));

            }

        } else
           if (once == false)
        {
            once = true;           
            StartCoroutine(Wait());
            
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        if (currentPointIndex + 1 < patrolPoints.Length)
        {
            currentPointIndex++;
        } else
        {
            currentPointIndex = 0;
        }
        once = false;
    }

    IEnumerator rotateDelay(int directType, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        if (directType == 0)
        {
            visionCone.transform.localPosition = new Vector3(1.1f, 0, 0);
            visionCone.transform.rotation = Quaternion.Euler(0, 0, 90f);
        }
        else if (directType == 1)
        {
            visionCone.transform.localPosition = new Vector3(-1.1f, 0, 0);
            visionCone.transform.rotation = Quaternion.Euler(0, 0, -90f);
        }
        else if (directType == 2)
        {
            visionCone.transform.localPosition = new Vector3(0, 1.4f, 0);
            visionCone.transform.rotation = Quaternion.Euler(0, 0, 180f);
        }
        else if (directType == 3)
        {
            visionCone.transform.localPosition = new Vector3(0, -1f, 0);
            visionCone.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

    }
}
