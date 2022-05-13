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

    // Update is called once per frame
   private void Update()
    {
       if(transform.position != patrolPoints[currentPointIndex].position)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, speed * Time.deltaTime);
        } else
           if (once == false)
        {
            once = true;
            StartCoroutine(Wait());
            transform.Rotate(0f, 0f, 180f, Space.Self);

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
}
